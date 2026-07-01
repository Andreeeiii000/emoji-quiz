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

    // Добавить вопрос. Используется и AdminForm, и SeedFromFile.
    public static void Add(string emoji, string answer, string category)
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

    //Вернуть случайный вопрос из базы
    //EF.Functions.Random() → SQL RANDOM(); возвращает null, если база пустая
    public static Question? GetRandom()
    {
        using var ctx = new QuizContext();
        return ctx.Questions
            .OrderBy(q => EF.Functions.Random())
            .FirstOrDefault();
    }

    // Несколько случайных НЕправильных ответов — для вариантов выбора.
    public static List<string> GetWrongAnswers(string correct, int count)
    {
        using var ctx = new QuizContext();
        return ctx.Questions
            .Where(q => q.Answer != correct)       //исключаем правильный
            .OrderBy(q => EF.Functions.Random())   //перемешиваем
            .Select(q => q.Answer)                 //берём только текст
            .Take(count)                           //столько, сколько просили
            .ToList();
    }

    // Заполнить базу из TSV-файла этапа 1.
    // Вызывается один раз при старте — если база уже заполнена, ничего не делает.
    public static void SeedFromFile(string path)
    {
        if (Count() > 0) return;   //уже заполнено - не задваиваем данные

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

        ctx.SaveChanges();   //один вызов для всех строк — так быстрее
    }
}