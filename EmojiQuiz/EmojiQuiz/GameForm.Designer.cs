using System.ComponentModel;

namespace EmojiQuiz;

partial class GameForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        labelEmoji = new System.Windows.Forms.Label();
        labelResult = new System.Windows.Forms.Label();
        labelScore = new System.Windows.Forms.Label();
        buttonOpt1 = new System.Windows.Forms.Button();
        buttonOpt2 = new System.Windows.Forms.Button();
        buttonOpt3 = new System.Windows.Forms.Button();
        buttonOpt4 = new System.Windows.Forms.Button();
        buttonBack = new System.Windows.Forms.Button();
        buttonNext = new System.Windows.Forms.Button();
        labelTimer = new System.Windows.Forms.Label();
        timerCountdown = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // labelEmoji
        // 
        labelEmoji.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        labelEmoji.Location = new System.Drawing.Point(283, 51);
        labelEmoji.Name = "labelEmoji";
        labelEmoji.Size = new System.Drawing.Size(228, 73);
        labelEmoji.TabIndex = 0;
        // 
        // labelResult
        // 
        labelResult.Location = new System.Drawing.Point(259, 140);
        labelResult.Name = "labelResult";
        labelResult.Size = new System.Drawing.Size(369, 27);
        labelResult.TabIndex = 1;
        // 
        // labelScore
        // 
        labelScore.Location = new System.Drawing.Point(688, 9);
        labelScore.Name = "labelScore";
        labelScore.Size = new System.Drawing.Size(100, 23);
        labelScore.TabIndex = 2;
        labelScore.Text = "Счёт: 0";
        // 
        // buttonOpt1
        // 
        buttonOpt1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)70)), ((int)((byte)83)));
        buttonOpt1.FlatAppearance.BorderSize = 0;
        buttonOpt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonOpt1.ForeColor = System.Drawing.Color.White;
        buttonOpt1.Location = new System.Drawing.Point(87, 244);
        buttonOpt1.Name = "buttonOpt1";
        buttonOpt1.Size = new System.Drawing.Size(185, 50);
        buttonOpt1.TabIndex = 3;
        buttonOpt1.UseVisualStyleBackColor = true;
        buttonOpt1.Click += buttonOpt1_Click;
        // 
        // buttonOpt2
        // 
        buttonOpt2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)70)), ((int)((byte)83)));
        buttonOpt2.FlatAppearance.BorderSize = 0;
        buttonOpt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonOpt2.ForeColor = System.Drawing.Color.White;
        buttonOpt2.Location = new System.Drawing.Point(507, 244);
        buttonOpt2.Name = "buttonOpt2";
        buttonOpt2.Size = new System.Drawing.Size(185, 50);
        buttonOpt2.TabIndex = 4;
        buttonOpt2.UseVisualStyleBackColor = true;
        buttonOpt2.Click += buttonOpt2_Click;
        // 
        // buttonOpt3
        // 
        buttonOpt3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)70)), ((int)((byte)83)));
        buttonOpt3.FlatAppearance.BorderSize = 0;
        buttonOpt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonOpt3.ForeColor = System.Drawing.Color.White;
        buttonOpt3.Location = new System.Drawing.Point(87, 321);
        buttonOpt3.Name = "buttonOpt3";
        buttonOpt3.Size = new System.Drawing.Size(185, 59);
        buttonOpt3.TabIndex = 5;
        buttonOpt3.UseVisualStyleBackColor = true;
        buttonOpt3.Click += buttonOpt3_Click;
        // 
        // buttonOpt4
        // 
        buttonOpt4.BackColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)70)), ((int)((byte)83)));
        buttonOpt4.FlatAppearance.BorderSize = 0;
        buttonOpt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonOpt4.ForeColor = System.Drawing.Color.White;
        buttonOpt4.Location = new System.Drawing.Point(507, 330);
        buttonOpt4.Name = "buttonOpt4";
        buttonOpt4.Size = new System.Drawing.Size(185, 50);
        buttonOpt4.TabIndex = 6;
        buttonOpt4.UseVisualStyleBackColor = true;
        buttonOpt4.Click += buttonOpt4_Click;
        // 
        // buttonBack
        // 
        buttonBack.BackColor = System.Drawing.Color.White;
        buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)70)), ((int)((byte)83)));
        buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)70)), ((int)((byte)83)));
        buttonBack.Location = new System.Drawing.Point(12, 12);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new System.Drawing.Size(112, 35);
        buttonBack.TabIndex = 7;
        buttonBack.Text = "< Назад в меню";
        buttonBack.UseVisualStyleBackColor = false;
        buttonBack.Click += buttonBack_Click;
        // 
        // buttonNext
        // 
        buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)70)), ((int)((byte)83)));
        buttonNext.FlatAppearance.BorderSize = 0;
        buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonNext.ForeColor = System.Drawing.Color.White;
        buttonNext.Location = new System.Drawing.Point(317, 388);
        buttonNext.Name = "buttonNext";
        buttonNext.Size = new System.Drawing.Size(149, 37);
        buttonNext.TabIndex = 8;
        buttonNext.Text = "Следующий вопрос!";
        buttonNext.UseVisualStyleBackColor = true;
        buttonNext.Click += buttonNext_Click;
        // 
        // labelTimer
        // 
        labelTimer.Location = new System.Drawing.Point(688, 32);
        labelTimer.Name = "labelTimer";
        labelTimer.Size = new System.Drawing.Size(100, 23);
        labelTimer.TabIndex = 9;
        labelTimer.Text = "label1";
        // 
        // timerCountdown
        // 
        timerCountdown.Interval = 1000;
        timerCountdown.Tick += timerCountdown_Tick;
        // 
        // GameForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)241)), ((int)((byte)250)), ((int)((byte)238)));
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(labelTimer);
        Controls.Add(buttonNext);
        Controls.Add(buttonBack);
        Controls.Add(buttonOpt4);
        Controls.Add(buttonOpt3);
        Controls.Add(buttonOpt2);
        Controls.Add(buttonOpt1);
        Controls.Add(labelScore);
        Controls.Add(labelResult);
        Controls.Add(labelEmoji);
        Text = "Игра";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Timer timerCountdown;

    private System.Windows.Forms.Label labelTimer;

    private System.Windows.Forms.Button buttonNext;

    private System.Windows.Forms.Button buttonBack;

    private System.Windows.Forms.Button buttonOpt4;

    private System.Windows.Forms.Button buttonOpt3;

    private System.Windows.Forms.Button buttonOpt2;

    private System.Windows.Forms.Button buttonOpt1;

    private System.Windows.Forms.Label labelScore;

    private System.Windows.Forms.Label labelResult;

    private System.Windows.Forms.Label labelEmoji;

    #endregion
}