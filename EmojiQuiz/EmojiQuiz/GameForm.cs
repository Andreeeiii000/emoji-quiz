namespace EmojiQuiz;

public partial class GameForm : Form
{
    private static readonly Random rng = new();
    
    private Question? current;
    
    private int score = 0;
    
    public GameForm()
    {
        InitializeComponent();
        //Первый вопрос - сразу при открытии окна
        NextQuestion();
    }
    
    private void NextQuestion()
    {
        current = Db.GetRandom();
 
        //Кнопка "Дальше" нужна только после ответа, мы ее прячем на время нового вопроса
        buttonNext.Visible = false;
 
        if (current == null)
        {
            labelEmoji.Text  = "😕";
            labelResult.Text = "База пустая. Добавьте вопросы в разделе «Администратор».";
            HideAllButtons();
            return;
        }
 
        labelEmoji.Text  = current.Emoji;
        labelResult.Text = "";   //убираем результат предыдущего вопроса
 
        // один правильный плюс три неправильных, затем перемешать
        var options = Db.GetWrongAnswers(current.Answer, 3);
        options.Add(current.Answer);
        Shuffle(options);
 
        // Сколько вариантов нашлось, столько кнопок и показываем.
        // Если в базе меньше четырёх разных ответов, лишние кнопки прячем,
        // иначе обращение к options[3] выбросит ошибку и программа упадёт.
        var buttons = new[] { buttonOpt1, buttonOpt2, buttonOpt3, buttonOpt4 };
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i < options.Count)
            {
                buttons[i].Text    = options[i];
                buttons[i].Visible = true;
                buttons[i].Enabled = true;   //включаем заново, так как на прошлом вопросе могли заблокировать
            }
            else
            {
                buttons[i].Visible = false;
            }
        }
    }
    
    // общий обработчик для всех четырёх кнопок
    private void CheckAnswer(string chosen)
    {
        if (current == null) return;   //база пустая - нечего проверять
 
        if (chosen == current.Answer)
        {
            score++;
            labelResult.Text = "✅ Верно!";
        }
        else
        {
            labelResult.Text = "❌ Неверно. Правильный ответ: " + current.Answer;
        }
 
        labelScore.Text = "Счёт: " + score;
 
        //Блокируем варианты, чтобы нельзя было кликнуть ещё раз по тому же вопросу,
        //и даем игроку время прочитать результат — следующий вопрос загрузится
        //только по нажатию buttonNext (в NextQuestion() мы не идём сразу).
        DisableAllButtons();
        buttonNext.Visible = true;
    }
    
    private static void Shuffle(List<string> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]); // меняем местами два элемента
        }
    }
 
    //Скрыть все кнопки вариантов (вызывается при пустой базе)
    private void HideAllButtons()
    {
        buttonOpt1.Visible = false;
        buttonOpt2.Visible = false;
        buttonOpt3.Visible = false;
        buttonOpt4.Visible = false;
    }
    
    //Заблокировать (но не скрыть) кнопки вариантов после ответа
    private void DisableAllButtons()
    {
        buttonOpt1.Enabled = false;
        buttonOpt2.Enabled = false;
        buttonOpt3.Enabled = false;
        buttonOpt4.Enabled = false;
    }

    private void buttonOpt1_Click(object sender, EventArgs e)
    {
        CheckAnswer(buttonOpt1.Text);
    }

    private void buttonOpt2_Click(object sender, EventArgs e)
    {
        CheckAnswer(buttonOpt2.Text);
    }

    private void buttonOpt3_Click(object sender, EventArgs e)
    {
        CheckAnswer(buttonOpt3.Text);
    }

    private void buttonOpt4_Click(object sender, EventArgs e)
    {
        CheckAnswer(buttonOpt4.Text);
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
        NextQuestion();
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}