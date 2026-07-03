namespace EmojiQuiz;

public partial class AdminForm : Form
{
    public AdminForm()
    {
        InitializeComponent();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        string emoji    = textEmoji.Text.Trim();   // rim убирает случайные пробелы
        string answer   = textAnswer.Text.Trim();
        string category = textCategory.Text.Trim();
 
        //Валидация: эмодзи и ответ обязательны
        if (emoji == "" || answer == "")
        {
            MessageBox.Show(
                "Заполните поля «Эмодзи» и «Ответ».",
                "Проверьте ввод",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }
 
        //Проверка дубликата: вопрос с таким ответом уже есть в базе
        if (Db.Exists(answer))
        {
            MessageBox.Show(
                $"Вопрос с ответом «{answer}» уже есть в базе.",
                "Дубликат",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }
 
        Db.Add(emoji, answer, category);
 
        MessageBox.Show(
            $"Вопрос добавлен!\n\n{emoji}  →  {answer}",
            "Готово",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
 
        textEmoji.Clear();
        textAnswer.Clear();
        textCategory.Clear();
        textEmoji.Focus();   //курсор сразу в первое поле
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}