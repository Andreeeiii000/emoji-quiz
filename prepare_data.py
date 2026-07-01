import pandas as pd

# --- ШАГ 1. Эмодзи-датасет с Kaggle ---
# read_csv читает файл в "DataFrame" — это таблица в памяти, по сути лист Excel.
# encoding="utf-8" обязателен: иначе на Windows русские буквы и эмодзи прочитаются кашей.
emoji = pd.read_csv("movies_emojis.csv", encoding="utf-8")
# Колонки в файле называются Movies и Emojis. Переименуем в понятные title_en и emoji.
emoji = emoji.rename(columns={"Movies": "title_en", "Emojis": "emoji"})
step1_count = len(emoji)
print("Фильмов с эмодзи:", step1_count)

# --- ШАГ 2. IMDb basics: коды и английские названия ---
# Файл большой, поэтому берём только 3 нужные колонки (usecols) — так уходит меньше памяти.
# sep="\t" — столбцы разделены табуляцией. na_values="\\N" — так IMDb помечает пропуск.
# quoting=3 — не обрабатывать кавычки (в названиях фильмов они встречаются и иначе всё ломается).
# dtype=str — читать всё как текст, не пытаться угадывать числа.
basics = pd.read_csv(
    "title.basics.tsv", sep="\t", na_values="\\N", quoting=3, dtype=str,
    encoding="utf-8", usecols=["tconst", "titleType", "primaryTitle"]
)
# Оставляем только фильмы (в файле есть ещё сериалы, эпизоды и т.д.).
movies = basics[basics["titleType"] == "movie"]
print("Всего записей в basics:", len(basics), "| из них фильмов:", len(movies))

# --- ШАГ 3. Находим код каждого фильма (с нормализацией названий) ---
# Нормализация: приводим к нижнему регистру и убираем пробелы по краям.
# Это позволяет находить совпадения, которые отличаются только регистром или пробелами.
# Например, "Spider-Man" и "Spider-man" теперь совпадут.
# Важно: нормализуем только вспомогательный ключ key, оригинальные поля не трогаем.
emoji["key"] = emoji["title_en"].str.lower().str.strip()
movies = movies.copy()
movies["key"] = movies["primaryTitle"].str.lower().str.strip()

# merge склеивает две таблицы по совпадающему ключу.
# how="inner" — оставить только те строки, что нашлись в обеих таблицах.
merged = emoji.merge(movies, on="key", how="inner")
# У одного названия может найтись несколько фильмов (ремейки, тёзки). Берём первый.
merged = merged.drop_duplicates(subset="title_en")
step3_count = len(merged)
print("Нашли код для фильмов:", step3_count)
print(f"  → потеря на шаге 3: {step1_count - step3_count} фильмов "
      f"({(step1_count - step3_count) / step1_count * 100:.1f}% от исходного)")

# --- ШАГ 4. IMDb akas: русские названия ---
# Этот файл огромный (~3 ГБ, ~58 млн строк), целиком в память он может не влезть.
# Поэтому читаем его КУСКАМИ по 2 млн строк и из каждого куска сразу оставляем только Россию.
# В итоге в памяти копятся только русские строки (их около 127 тысяч) — это немного.
parts = []
for chunk in pd.read_csv(
    "title.akas.tsv", sep="\t", na_values="\\N", quoting=3, dtype=str,
    encoding="utf-8", usecols=["titleId", "title", "region"], chunksize=2_000_000
):
    parts.append(chunk[chunk["region"] == "RU"])
ru = pd.concat(parts)
# У фильма может быть несколько русских строк, оставляем по одной на код.
ru = ru.drop_duplicates(subset="titleId")
# Переименуем столбцы: titleId -> tconst (чтобы склеивать по общему имени), title -> title_ru.
ru = ru.rename(columns={"titleId": "tconst", "title": "title_ru"})
print("Русских названий нашли:", len(ru))

# --- ШАГ 5. Склеиваем эмодзи с русским названием по коду tconst ---
result = merged.merge(ru, on="tconst", how="inner")

# --- ШАГ 6. Сохраняем три нужные колонки ---
# Сохраняем через табуляцию (sep="\t"), чтобы запятые внутри названий не ломали разбор в приложении.
# dropna() убирает строки с пустыми значениями (страховка — после inner-склейки их почти не остаётся).
final = result[["tconst", "title_ru", "emoji"]].dropna()
final.to_csv("movies_ru_emoji.tsv", sep="\t", index=False, encoding="utf-8")

step6_count = len(final)
print("ИТОГО строк в результате:", step6_count)
print(final.head())

# --- МИНИ-АНАЛИЗ: разбор потерь по шагам ---
print("\n" + "=" * 50)
print("МИНИ-АНАЛИЗ ПОТЕРЬ")
print("=" * 50)
lost_step3 = step1_count - step3_count
lost_step4 = step3_count - step6_count
print(f"Исходных фильмов с эмодзи:         {step1_count}")
print(f"Найдено в IMDb (шаг 3):             {step3_count}"
      f"  (потеря: {lost_step3}, {lost_step3 / step1_count * 100:.1f}%)")
print(f"Из них с русским названием (шаг 4): {step6_count}"
      f"  (потеря: {lost_step4}, {lost_step4 / step3_count * 100:.1f}%)")
print(f"Итоговая доля от исходного:         {step6_count / step1_count * 100:.1f}%")
print(f"\nВывод: основная потеря — отсутствие русского перевода в IMDb")
print(f"({lost_step4} из {lost_step3 + lost_step4} потерянных, "
      f"{lost_step4 / (lost_step3 + lost_step4) * 100:.0f}% всех потерь)")