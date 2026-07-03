namespace EmojiQuiz;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        labelTitle = new System.Windows.Forms.Label();
        buttonPlay = new System.Windows.Forms.Button();
        buttonAdmin = new System.Windows.Forms.Button();
        comboCategory = new System.Windows.Forms.ComboBox();
        comboRoundLength = new System.Windows.Forms.ComboBox();
        comboTimeLimit = new System.Windows.Forms.ComboBox();
        labelCategory = new System.Windows.Forms.Label();
        labelRoundLength = new System.Windows.Forms.Label();
        labelTimeLimit = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        labelTitle.Location = new System.Drawing.Point(188, 43);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new System.Drawing.Size(412, 78);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Угадай по смайликам 🎬";
        // 
        // buttonPlay
        // 
        buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)70)), ((int)((byte)83)));
        buttonPlay.FlatAppearance.BorderSize = 0;
        buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonPlay.ForeColor = System.Drawing.Color.White;
        buttonPlay.Location = new System.Drawing.Point(152, 275);
        buttonPlay.Name = "buttonPlay";
        buttonPlay.Size = new System.Drawing.Size(136, 50);
        buttonPlay.TabIndex = 1;
        buttonPlay.Text = "▶  Играть";
        buttonPlay.UseVisualStyleBackColor = true;
        buttonPlay.Click += buttonPlay_Click;
        // 
        // buttonAdmin
        // 
        buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)70)), ((int)((byte)83)));
        buttonAdmin.FlatAppearance.BorderSize = 0;
        buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonAdmin.ForeColor = System.Drawing.Color.White;
        buttonAdmin.Location = new System.Drawing.Point(474, 275);
        buttonAdmin.Name = "buttonAdmin";
        buttonAdmin.Size = new System.Drawing.Size(147, 50);
        buttonAdmin.TabIndex = 2;
        buttonAdmin.Text = "⚙  Администратор";
        buttonAdmin.UseVisualStyleBackColor = true;
        buttonAdmin.Click += buttonAdmin_Click;
        // 
        // comboCategory
        // 
        comboCategory.FormattingEnabled = true;
        comboCategory.Location = new System.Drawing.Point(152, 186);
        comboCategory.Name = "comboCategory";
        comboCategory.Size = new System.Drawing.Size(121, 23);
        comboCategory.TabIndex = 3;
        // 
        // comboRoundLength
        // 
        comboRoundLength.FormattingEnabled = true;
        comboRoundLength.Location = new System.Drawing.Point(332, 186);
        comboRoundLength.Name = "comboRoundLength";
        comboRoundLength.Size = new System.Drawing.Size(121, 23);
        comboRoundLength.TabIndex = 4;
        // 
        // comboTimeLimit
        // 
        comboTimeLimit.FormattingEnabled = true;
        comboTimeLimit.Location = new System.Drawing.Point(500, 186);
        comboTimeLimit.Name = "comboTimeLimit";
        comboTimeLimit.Size = new System.Drawing.Size(121, 23);
        comboTimeLimit.TabIndex = 5;
        // 
        // labelCategory
        // 
        labelCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        labelCategory.Location = new System.Drawing.Point(152, 160);
        labelCategory.Name = "labelCategory";
        labelCategory.Size = new System.Drawing.Size(100, 23);
        labelCategory.TabIndex = 6;
        labelCategory.Text = "Категория:";
        // 
        // labelRoundLength
        // 
        labelRoundLength.Location = new System.Drawing.Point(332, 160);
        labelRoundLength.Name = "labelRoundLength";
        labelRoundLength.Size = new System.Drawing.Size(121, 23);
        labelRoundLength.TabIndex = 7;
        labelRoundLength.Text = "Кол-во вопросов:";
        // 
        // labelTimeLimit
        // 
        labelTimeLimit.Location = new System.Drawing.Point(500, 160);
        labelTimeLimit.Name = "labelTimeLimit";
        labelTimeLimit.Size = new System.Drawing.Size(100, 23);
        labelTimeLimit.TabIndex = 8;
        labelTimeLimit.Text = "Кол-во времени:";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)241)), ((int)((byte)250)), ((int)((byte)238)));
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(labelTimeLimit);
        Controls.Add(labelRoundLength);
        Controls.Add(labelCategory);
        Controls.Add(comboTimeLimit);
        Controls.Add(comboRoundLength);
        Controls.Add(comboCategory);
        Controls.Add(buttonAdmin);
        Controls.Add(buttonPlay);
        Controls.Add(labelTitle);
        Text = "Угадай по смайликам";
        Load += MainForm_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label labelTimeLimit;

    private System.Windows.Forms.Label labelRoundLength;

    private System.Windows.Forms.Label labelCategory;

    private System.Windows.Forms.ComboBox comboCategory;

    private System.Windows.Forms.ComboBox comboTimeLimit;

    private System.Windows.Forms.ComboBox comboRoundLength;

    private System.Windows.Forms.Button buttonPlay;
    private System.Windows.Forms.Button buttonAdmin;

    private System.Windows.Forms.Label labelTitle;

    #endregion
}
