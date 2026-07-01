namespace EmojiQuiz;

public partial class AdminForm : Form
{
    public AdminForm()
    {
        InitializeComponent();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        string emoji    = textEmoji.Text.Trim();    //Trim убирает случайные пробелы
        string answer   = textAnswer.Text.Trim();
        string category = textCategory.Text.Trim();
        
        if (emoji == "" || answer == "")
        {
            MessageBox.Show(
                "Заполните поля «Эмодзи» и «Ответ».",
                "Проверьте ввод",
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