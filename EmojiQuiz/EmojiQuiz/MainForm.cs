namespace EmojiQuiz;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }
    
    private void buttonPlay_Click(object sender, EventArgs e)
    {
        string? category    = comboCategory.SelectedItem as string;
        int     roundLength = int.Parse((string)comboRoundLength.SelectedItem);
        int     timeLimit   = int.Parse((string)comboTimeLimit.SelectedItem);
 
        // ShowDialog() блокирует меню, пока окно игры не закроют.
        new GameForm(category, roundLength, timeLimit).ShowDialog();
    }
    
    private void buttonAdmin_Click(object sender, EventArgs e)
    {
        new AdminForm().ShowDialog();
    }

    //Заполняем все три списка при открытии меню
    private void MainForm_Load(object sender, EventArgs e)
    {
        //Категории: "Все категории" + то, что реально есть в базе
        comboCategory.Items.Clear();
        comboCategory.Items.Add("Все категории");
        foreach (var category in Db.GetCategories())
            comboCategory.Items.Add(category);
        comboCategory.SelectedIndex = 0;
 
        //Сколько вопросов в раунде
        comboRoundLength.Items.Clear();
        comboRoundLength.Items.AddRange(new object[] { "5", "10", "15" });
        comboRoundLength.SelectedIndex = 1;   // по умолчанию 10
 
        //Сколько секунд даётся на ответ
        comboTimeLimit.Items.Clear();
        comboTimeLimit.Items.AddRange(new object[] { "10", "15", "20" });
        comboTimeLimit.SelectedIndex = 1;
    }
}
