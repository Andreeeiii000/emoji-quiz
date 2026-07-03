namespace EmojiQuiz;

using Microsoft.EntityFrameworkCore;

//Весь доступ к базе собран в этом статическом классе
//Формы не работают с базой напрямую — только через методы Db
//Каждый метод сам открывает и закрывает контекст (using var ctx = ...)
static class Db
{
    // Создать базу и таблицу по описанию модели, если их ещё нет.
    public static void EnsureCreated()
    {
        using var ctx = new QuizContext();
        ctx.Database.EnsureCreated();
    }
 
    // Сколько вопросов сейчас в базе.
    public static int Count()
    {
        using var ctx = new QuizContext();
        return ctx.Questions.Count();
    }
 
    // Проверить, есть ли в базе вопрос с таким же ответом.
    // Используется в AdminForm перед добавлением — чтобы не было дубликатов.
    public static bool Exists(string answer)
    {
        using var ctx = new QuizContext();
        return ctx.Questions.Any(q => q.Answer == answer);
    }
    
    // Добавить вопрос. Используется и AdminForm, и SeedFromFile.
    public static void Add(string emoji, string answer, string? category)
    {
        using var ctx = new QuizContext();
        ctx.Questions.Add(new Question
        {
            Emoji    = emoji,
            Answer   = answer,
            Category = category ?? ""
        });
        ctx.SaveChanges();   // без SaveChanges изменения не сохранятся в файл
    }
 
    // НОВОЕ (пункт 5): список категорий, которые реально есть в базе, без повторов, по алфавиту.
    // Используется в MainForm для заполнения comboCategory.
    public static List<string> GetCategories()
    {
        using var ctx = new QuizContext();
        return ctx.Questions
            .Select(q => q.Category)
            .Where(c => c != "")
            .Distinct()
            .OrderBy(c => c)
            .ToList();
    }
 
    // ИЗМЕНЕНО (пункт 5): добавлен необязательный параметр category.
    // category == null или "Все категории" — вопрос из любой категории (как было раньше).
    // Иначе — только из указанной категории.
    // EF.Functions.Random() → SQL RANDOM(); возвращает null, если подходящих строк нет.
    public static Question? GetRandom(string? category = null, int? excludeId = null)
    {
        using var ctx = new QuizContext();
        var query = ctx.Questions.AsQueryable();

        if (!string.IsNullOrEmpty(category) && category != "Все категории")
            query = query.Where(q => q.Category == category);

        var filtered = excludeId.HasValue
            ? query.Where(q => q.Id != excludeId.Value)
            : query;

        var result = filtered.OrderBy(q => EF.Functions.Random()).FirstOrDefault();

        // Если исключили единственный вопрос в категории — вернём его же,
        // иначе игра решит, что вопросы кончились.
        if (result == null && excludeId.HasValue)
            result = query.OrderBy(q => EF.Functions.Random()).FirstOrDefault();

        return result;
    }
 
    // Вернуть count случайных НЕПРАВИЛЬНЫХ ответов — для кнопок вариантов.
    // Берём из всей базы (не только из выбранной категории), чтобы вариантов
    // хватало даже для маленькой категории.
    // Distinct() стоит ДО OrderBy(Random()), иначе EF Core выбросит ORDER BY из SQL
    // и варианты перестанут быть случайными (всегда одни и те же три).
    public static List<string> GetWrongAnswers(string correct, int count)
    {
        using var ctx = new QuizContext();
        return ctx.Questions
            .Where(q => q.Answer != correct)       // исключаем правильный
            .Select(q => q.Answer)                 // берём только текст
            .Distinct()                            // убираем повторы (если один ответ в базе дважды)
            .OrderBy(q => EF.Functions.Random())   // перемешиваем уже уникальные
            .Take(count)                           // столько, сколько просили
            .ToList();
    }
 
    // Заполнить базу из TSV-файла этапа 1.
    // Вызывается один раз при старте — если база уже заполнена, ничего не делает.
    public static void SeedFromFile(string path)
    {
        if (Count() > 0) return;   // уже заполнено — не задваиваем данные
 
        using var ctx = new QuizContext();
 
        foreach (var line in File.ReadLines(path, System.Text.Encoding.UTF8).Skip(1))
        {
            var parts = line.Split('\t');          // колонки: tconst, title_ru, emoji
            if (parts.Length < 3) continue;        // битую строку пропускаем
 
            ctx.Questions.Add(new Question
            {
                Emoji    = parts[2],
                Answer   = parts[1],
                Category = "Фильмы"
            });
        }
 
        ctx.SaveChanges();   // один вызов для всех строк — так быстрее
    }
}