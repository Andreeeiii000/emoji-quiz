namespace EmojiQuiz;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }
    
    private void buttonPlay_Click(object sender, EventArgs e)
    {
        //Игрок не сможет откр. несколько окон игры одновременно
        new GameForm().ShowDialog();
    }
    
    private void buttonAdmin_Click(object sender, EventArgs e)
    {
        new AdminForm().ShowDialog();
    }
}
