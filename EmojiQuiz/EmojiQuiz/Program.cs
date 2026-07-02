namespace EmojiQuiz;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // Стандартная инициализация WinForms (DPI, визуальные стили).
        ApplicationConfiguration.Initialize();
 
        // Создать базу и таблицу, затем заполнить из файла этапа 1.
        // Оба шага обёрнуты в try/catch: если файл не найден или база занята,
        // пользователь увидит понятное сообщение, а не трассировку стека.
        try
        {
            Db.EnsureCreated();
            Db.SeedFromFile("movies_ru_emoji.tsv");
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Не удалось подготовить базу данных:\n" + ex.Message,
                "Ошибка запуска",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;   // не запускаем игру на нерабочей базе
        }
 
        Application.Run(new MainForm());
    }
}