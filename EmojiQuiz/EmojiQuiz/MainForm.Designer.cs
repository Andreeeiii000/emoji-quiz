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
        label1 = new System.Windows.Forms.Label();
        buttonPlay = new System.Windows.Forms.Button();
        buttonAdmin = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.Location = new System.Drawing.Point(240, 73);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(317, 71);
        label1.TabIndex = 0;
        label1.Text = "Угадай по смайликам 🎬";
        // 
        // buttonPlay
        // 
        buttonPlay.Location = new System.Drawing.Point(152, 233);
        buttonPlay.Name = "buttonPlay";
        buttonPlay.Size = new System.Drawing.Size(101, 38);
        buttonPlay.TabIndex = 1;
        buttonPlay.Text = "▶  Играть";
        buttonPlay.UseVisualStyleBackColor = true;
        buttonPlay.Click += buttonPlay_Click;
        // 
        // buttonAdmin
        // 
        buttonAdmin.Location = new System.Drawing.Point(517, 233);
        buttonAdmin.Name = "buttonAdmin";
        buttonAdmin.Size = new System.Drawing.Size(134, 38);
        buttonAdmin.TabIndex = 2;
        buttonAdmin.Text = "⚙  Администратор";
        buttonAdmin.UseVisualStyleBackColor = true;
        buttonAdmin.Click += buttonAdmin_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonAdmin);
        Controls.Add(buttonPlay);
        Controls.Add(label1);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonPlay;
    private System.Windows.Forms.Button buttonAdmin;

    private System.Windows.Forms.Label label1;

    #endregion
}
