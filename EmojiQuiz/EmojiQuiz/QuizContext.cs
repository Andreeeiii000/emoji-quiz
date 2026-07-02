namespace EmojiQuiz;

using Microsoft.EntityFrameworkCore;

//QuizContext — это некий "мост" между объектами C# и базой данных
//EF Core смотрит на DbSet<Question> и знает, что ему нужна таблица Questions
class QuizContext : DbContext
{
    //Таблица вопросов. Запись "=> Set<Question>()" — рекомендованный EF Core способ,
    //чтобы не было предупреждения компилятора про возможный null
    public DbSet<Question> Questions => Set<Question>();

    //Говорим EF Core: база — файл quiz.db рядом с программой
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=quiz.db");
    }
}