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
        labelEmoji = new System.Windows.Forms.Label();
        labelResult = new System.Windows.Forms.Label();
        labelScore = new System.Windows.Forms.Label();
        buttonOpt1 = new System.Windows.Forms.Button();
        buttonOpt2 = new System.Windows.Forms.Button();
        buttonOpt3 = new System.Windows.Forms.Button();
        buttonOpt4 = new System.Windows.Forms.Button();
        buttonBack = new System.Windows.Forms.Button();
        buttonNext = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // labelEmoji
        // 
        labelEmoji.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        labelEmoji.Location = new System.Drawing.Point(283, 51);
        labelEmoji.Name = "labelEmoji";
        labelEmoji.Size = new System.Drawing.Size(228, 73);
        labelEmoji.TabIndex = 0;
        labelEmoji.Text = "label1";
        // 
        // labelResult
        // 
        labelResult.Location = new System.Drawing.Point(259, 140);
        labelResult.Name = "labelResult";
        labelResult.Size = new System.Drawing.Size(369, 27);
        labelResult.TabIndex = 1;
        labelResult.Text = "label1";
        // 
        // labelScore
        // 
        labelScore.Location = new System.Drawing.Point(688, 9);
        labelScore.Name = "labelScore";
        labelScore.Size = new System.Drawing.Size(100, 23);
        labelScore.TabIndex = 2;
        labelScore.Text = "Очки: 0";
        // 
        // buttonOpt1
        // 
        buttonOpt1.Location = new System.Drawing.Point(87, 244);
        buttonOpt1.Name = "buttonOpt1";
        buttonOpt1.Size = new System.Drawing.Size(185, 50);
        buttonOpt1.TabIndex = 3;
        buttonOpt1.Text = "button1";
        buttonOpt1.UseVisualStyleBackColor = true;
        buttonOpt1.Click += buttonOpt1_Click;
        // 
        // buttonOpt2
        // 
        buttonOpt2.Location = new System.Drawing.Point(523, 244);
        buttonOpt2.Name = "buttonOpt2";
        buttonOpt2.Size = new System.Drawing.Size(157, 50);
        buttonOpt2.TabIndex = 4;
        buttonOpt2.Text = "button1";
        buttonOpt2.UseVisualStyleBackColor = true;
        buttonOpt2.Click += buttonOpt2_Click;
        // 
        // buttonOpt3
        // 
        buttonOpt3.Location = new System.Drawing.Point(87, 321);
        buttonOpt3.Name = "buttonOpt3";
        buttonOpt3.Size = new System.Drawing.Size(185, 59);
        buttonOpt3.TabIndex = 5;
        buttonOpt3.Text = "button1";
        buttonOpt3.UseVisualStyleBackColor = true;
        buttonOpt3.Click += buttonOpt3_Click;
        // 
        // buttonOpt4
        // 
        buttonOpt4.Location = new System.Drawing.Point(523, 321);
        buttonOpt4.Name = "buttonOpt4";
        buttonOpt4.Size = new System.Drawing.Size(157, 59);
        buttonOpt4.TabIndex = 6;
        buttonOpt4.Text = "button1";
        buttonOpt4.UseVisualStyleBackColor = true;
        buttonOpt4.Click += buttonOpt4_Click;
        // 
        // buttonBack
        // 
        buttonBack.Location = new System.Drawing.Point(12, 12);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new System.Drawing.Size(112, 35);
        buttonBack.TabIndex = 7;
        buttonBack.Text = "< Назад в меню";
        buttonBack.UseVisualStyleBackColor = true;
        buttonBack.Click += buttonBack_Click;
        // 
        // buttonNext
        // 
        buttonNext.Location = new System.Drawing.Point(328, 388);
        buttonNext.Name = "buttonNext";
        buttonNext.Size = new System.Drawing.Size(149, 37);
        buttonNext.TabIndex = 8;
        buttonNext.Text = "Следующий вопрос!";
        buttonNext.UseVisualStyleBackColor = true;
        buttonNext.Click += buttonNext_Click;
        // 
        // GameForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonNext);
        Controls.Add(buttonBack);
        Controls.Add(buttonOpt4);
        Controls.Add(buttonOpt3);
        Controls.Add(buttonOpt2);
        Controls.Add(buttonOpt1);
        Controls.Add(labelScore);
        Controls.Add(labelResult);
        Controls.Add(labelEmoji);
        Text = "Gameform";
        ResumeLayout(false);
    }

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