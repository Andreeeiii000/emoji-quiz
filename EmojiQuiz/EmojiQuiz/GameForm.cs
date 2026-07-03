namespace EmojiQuiz;

public partial class GameForm : Form
{
    private static readonly Random rng = new();
 
    private Question? current;
 
    private int score = 0;
 
    //параметры раунда, которые приходят из MainForm
    private readonly string? category;      //null или "Все категории" — без фильтра
    private readonly int roundLength;        //сколько вопросов в раунде
    private readonly int timeLimitSeconds;   //сколько секунд на один вопрос
    
    private int? lastQuestionId;   
 
    private int questionsAsked = 0;          //сколько вопросов уже показано
    private int timeLeft;                    //сколько секунд осталось на текущий вопрос
 
    //Конструктор без параметров нужен визуальному конструктору форм Rider —
    //он просто запускает игру с настройками по умолчанию (без фильтра, 10 вопросов, 15 секунд)
    public GameForm() : this(null, 10, 15) { }
    
    //Основной конструктор - вызывается из MainForm с настройками, которые выбрал игрок.
    public GameForm(string? category, int roundLength, int timeLimitSeconds)
    {
        InitializeComponent();
 
        this.category         = category;
        this.roundLength      = roundLength;
        this.timeLimitSeconds = timeLimitSeconds;
        
        NextQuestion();
    }
    
    private void NextQuestion()
    {
        questionsAsked++;
 
        // Раунд закончен - показать итог и вернуться в меню
        if (questionsAsked > roundLength)
        {
            timerCountdown.Stop();
            MessageBox.Show(
                $"Раунд завершён!\n\nВаш счёт: {score} из {roundLength}",
                "Результат",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
            return;
        }
 
        current = Db.GetRandom(category, lastQuestionId);
        
        buttonNext.Visible = false;
 
        if (current == null)
        {
            timerCountdown.Stop();
            labelEmoji.Text  = "😕";
            labelResult.Text = string.IsNullOrEmpty(category) || category == "Все категории"
                ? "База пустая. Добавьте вопросы в разделе «Администратор»."
                : $"В категории «{category}» пока нет вопросов.";
            labelTimer.Text = "";
            HideAllButtons();
            return;
        }
 
        labelEmoji.Text  = current.Emoji;
        lastQuestionId = current.Id;
        labelResult.Text = "";   //убир. результат предыдущего вопроса
 
        // один правильный плюс три неправильных, затем перемешать
        var options = Db.GetWrongAnswers(current.Answer, 3);
        options.Add(current.Answer);
        Shuffle(options);
 
        //Сколько вариантов нашлось, столько кнопок и показываем. 
        //Если в нашем базе меньше четырёх разных ответов, лишние кнопки прячем, иначе обращение к options[3] выбросит ошибку и программа упадет
        var buttons = new[] { buttonOpt1, buttonOpt2, buttonOpt3, buttonOpt4 };
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i < options.Count)
            {
                buttons[i].Text    = options[i];
                buttons[i].Visible = true;
                buttons[i].Enabled = true;   //включаем заново - на прошлом вопросе могли заблокировать
            }
            else
            {
                buttons[i].Visible = false;
            }
        }
 
        //запускаем обратный отсчет для нового вопроса.
        StartTimer();
    }
    
    //Запустить таймер заново на timeLimitSeconds секунд.
    private void StartTimer()
    {
        timeLeft = timeLimitSeconds;
        labelTimer.Text = "⏱ " + timeLeft;
        timerCountdown.Stop();
        timerCountdown.Start();
    }
 
    //Обработчик тика таймера - вызывается раз в секунду, пока таймер запущен.
    private void timerCountdown_Tick(object sender, EventArgs e)
    {
        timeLeft--;
        labelTimer.Text = "⏱ " + timeLeft;
 
        if (timeLeft <= 0)
        {
            timerCountdown.Stop();
            TimeUp();
        }
    }
 
    //Время вышло - считаем это неверным ответом, но без выбранного варианта
    private void TimeUp()
    {
        if (current == null) return;
 
        labelResult.Text = "⌛ Время вышло! Правильный ответ: " + current.Answer;
        labelScore.Text  = "Счёт: " + score;   
 
        DisableAllButtons();
        buttonNext.Visible = true;
    }
    
    // общий обработчик для всех четырёх кнопок
    private void CheckAnswer(string chosen)
    {
        if (current == null) return;   //база пустая - нечего проверять
 
        timerCountdown.Stop();   //ответили - таймер больше не нужен
 
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
 
        // Блокируем варианты, чтобы нельзя было кликнуть ещё раз по тому же вопросу
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
        timerCountdown.Stop();
        this.Close();
    }
}