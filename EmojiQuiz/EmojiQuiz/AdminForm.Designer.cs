using System.ComponentModel;

namespace EmojiQuiz;

partial class AdminForm
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
        label1 = new System.Windows.Forms.Label();
        textEmoji = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        textAnswer = new System.Windows.Forms.TextBox();
        textCategory = new System.Windows.Forms.TextBox();
        buttonAdd = new System.Windows.Forms.Button();
        buttonBack = new System.Windows.Forms.Button();
        label3 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(93, 119);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 0;
        label1.Text = "Эмодзи:";
        // 
        // textEmoji
        // 
        textEmoji.Location = new System.Drawing.Point(199, 119);
        textEmoji.Name = "textEmoji";
        textEmoji.Size = new System.Drawing.Size(202, 23);
        textEmoji.TabIndex = 1;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(93, 181);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 2;
        label2.Text = "Ответ:";
        // 
        // textAnswer
        // 
        textAnswer.Location = new System.Drawing.Point(199, 183);
        textAnswer.Name = "textAnswer";
        textAnswer.Size = new System.Drawing.Size(202, 23);
        textAnswer.TabIndex = 3;
        // 
        // textCategory
        // 
        textCategory.Location = new System.Drawing.Point(199, 240);
        textCategory.Name = "textCategory";
        textCategory.Size = new System.Drawing.Size(202, 23);
        textCategory.TabIndex = 5;
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new System.Drawing.Point(320, 356);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new System.Drawing.Size(141, 50);
        buttonAdd.TabIndex = 6;
        buttonAdd.Text = "Сохранить!";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // buttonBack
        // 
        buttonBack.Location = new System.Drawing.Point(12, 12);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new System.Drawing.Size(120, 29);
        buttonBack.TabIndex = 7;
        buttonBack.Text = "< Назад в меню";
        buttonBack.UseVisualStyleBackColor = true;
        buttonBack.Click += buttonBack_Click;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(93, 240);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 8;
        label3.Text = "Категория:";
        // 
        // AdminForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label3);
        Controls.Add(buttonBack);
        Controls.Add(buttonAdd);
        Controls.Add(textCategory);
        Controls.Add(textAnswer);
        Controls.Add(label2);
        Controls.Add(textEmoji);
        Controls.Add(label1);
        Text = "Администратор";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Button buttonBack;

    private System.Windows.Forms.Button buttonAdd;

    private System.Windows.Forms.TextBox textCategory;

    private System.Windows.Forms.TextBox textAnswer;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox textEmoji;

    private System.Windows.Forms.Label label1;

    #endregion
}