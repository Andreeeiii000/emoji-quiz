namespace EmojiQuiz;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        //Стандартная инициализация WinForms (DPI, визуальные стили)
        ApplicationConfiguration.Initialize();
 
        //Создать базу и таблицу, если их ещё нет.
        Db.EnsureCreated();
 
        //Заполнить из файла этапа 1 - только при первом запуске
        //Если quiz.db уже содержит записи, SeedFromFile ничего не делает
        Db.SeedFromFile("movies_ru_emoji.tsv");
 
        //Запустить главное окно
        Application.Run(new MainForm());
    }
}