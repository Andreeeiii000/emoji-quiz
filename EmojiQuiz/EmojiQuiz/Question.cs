namespace EmojiQuiz;

//Модель вопроса: один объект = одна строка таблицы в базе данных.
//EF Core по соглашению делает свойство Id первичным ключом и заполняет его сам.
class Question
{
    public int    Id       { get; set; }
    public string Emoji    { get; set; } = "";
    public string Answer   { get; set; } = "";
    public string Category { get; set; } = "";
}