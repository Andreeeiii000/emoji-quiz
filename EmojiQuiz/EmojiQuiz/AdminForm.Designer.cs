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
        labelEmojiCaption = new System.Windows.Forms.Label();
        textEmoji = new System.Windows.Forms.TextBox();
        labelAnswerCaption = new System.Windows.Forms.Label();
        textAnswer = new System.Windows.Forms.TextBox();
        textCategory = new System.Windows.Forms.TextBox();
        buttonAdd = new System.Windows.Forms.Button();
        buttonBack = new System.Windows.Forms.Button();
        labelCategoryCaption = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // labelEmojiCaption
        // 
        labelEmojiCaption.Location = new System.Drawing.Point(93, 119);
        labelEmojiCaption.Name = "labelEmojiCaption";
        labelEmojiCaption.Size = new System.Drawing.Size(100, 23);
        labelEmojiCaption.TabIndex = 0;
        labelEmojiCaption.Text = "Эмодзи:";
        // 
        // textEmoji
        // 
        textEmoji.Location = new System.Drawing.Point(199, 119);
        textEmoji.Name = "textEmoji";
        textEmoji.Size = new System.Drawing.Size(202, 23);
        textEmoji.TabIndex = 1;
        // 
        // labelAnswerCaption
        // 
        labelAnswerCaption.Location = new System.Drawing.Point(93, 181);
        labelAnswerCaption.Name = "labelAnswerCaption";
        labelAnswerCaption.Size = new System.Drawing.Size(100, 23);
        labelAnswerCaption.TabIndex = 2;
        labelAnswerCaption.Text = "Ответ:";
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
        buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonAdd.FlatAppearance.BorderSize = 0;
        buttonAdd.BackColor = System.Drawing.Color.FromArgb(38, 70, 83);
        buttonAdd.ForeColor = System.Drawing.Color.White;
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
        buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonBack.FlatAppearance.BorderSize = 1;
        buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(38, 70, 83);
        buttonBack.BackColor = System.Drawing.Color.White;
        buttonBack.ForeColor = System.Drawing.Color.FromArgb(38, 70, 83);
        buttonBack.TabIndex = 7;
        buttonBack.Text = "< Назад в меню";
        buttonBack.UseVisualStyleBackColor = true;
        buttonBack.Click += buttonBack_Click;
        // 
        // labelCategoryCaption
        // 
        labelCategoryCaption.Location = new System.Drawing.Point(93, 240);
        labelCategoryCaption.Name = "labelCategoryCaption";
        labelCategoryCaption.Size = new System.Drawing.Size(100, 23);
        labelCategoryCaption.TabIndex = 8;
        labelCategoryCaption.Text = "Категория:";
        // 
        // AdminForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        BackColor = System.Drawing.Color.FromArgb(241, 250, 238);
        Controls.Add(labelCategoryCaption);
        Controls.Add(buttonBack);
        Controls.Add(buttonAdd);
        Controls.Add(textCategory);
        Controls.Add(textAnswer);
        Controls.Add(labelAnswerCaption);
        Controls.Add(textEmoji);
        Controls.Add(labelEmojiCaption);
        Text = "Администратор";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label labelCategoryCaption;

    private System.Windows.Forms.Button buttonBack;

    private System.Windows.Forms.Button buttonAdd;

    private System.Windows.Forms.TextBox textCategory;

    private System.Windows.Forms.TextBox textAnswer;

    private System.Windows.Forms.Label labelAnswerCaption;

    private System.Windows.Forms.TextBox textEmoji;

    private System.Windows.Forms.Label labelEmojiCaption;

    #endregion
}