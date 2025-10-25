namespace Millionaire;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.Button withDraw;
    private System.Windows.Forms.Button swiitchQuestionButton;
    private System.Windows.Forms.Button fiftyFifty;
    private System.Windows.Forms.Label currentMoneyLabel;
    private System.Windows.Forms.Label moneyLabel;
    private System.Windows.Forms.Label levelLabel;
    private System.Windows.Forms.Label questionText;
    private System.Windows.Forms.Button answerA;
    private System.Windows.Forms.Button answerB;
    private System.Windows.Forms.Button answerC;
    private System.Windows.Forms.Button answerD;
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        // creating clicks, labels and buttons
        // startButton
        this.startButton = new System.Windows.Forms.Button();
        this.startButton.Text = "Start Game";
        this.startButton.Location = new Point(620, 0);
        this.startButton.Size = new Size(180, 100);
        this.startButton.Click += new System.EventHandler(startButton_Click);
        this.Controls.Add(this.startButton);

        // current money label
        this.currentMoneyLabel = new System.Windows.Forms.Label();
        this.currentMoneyLabel.Text = "Current Money: $";
        this.currentMoneyLabel.Location = new Point(360, 100);
        this.Controls.Add(this.currentMoneyLabel);

        // money label
        this.moneyLabel = new System.Windows.Forms.Label();
        this.moneyLabel.Text = "Money: $";
        this.moneyLabel.Location = new Point(185, 100);
        this.Controls.Add(this.moneyLabel);
        
        // level label
        this.levelLabel = new System.Windows.Forms.Label();
        this.levelLabel.Text = "Level: ";
        this.levelLabel.Location = new Point(10, 100);
        this.Controls.Add(this.levelLabel);

        // 50:50 choice button
        this.fiftyFifty = new System.Windows.Forms.Button();
        this.fiftyFifty.Text = "FiftyFifty";
        this.fiftyFifty.Click += (s, e) => MessageBox.Show("Hello from 50:50");
        this.fiftyFifty.Location = new Point(0, 250);
        this.fiftyFifty.Size = new Size(300, 25);
        this.Controls.Add(this.fiftyFifty);

        // switch question choice button
        this.swiitchQuestionButton = new System.Windows.Forms.Button();
        this.swiitchQuestionButton.Text = "SwitchQuestion";
        this.swiitchQuestionButton.Click += (s, e) => MessageBox.Show("Hello from switch questoin");
        this.swiitchQuestionButton.Location = new Point(300, 250);
        this.swiitchQuestionButton.Size = new Size(300, 25);
        this.Controls.Add(this.swiitchQuestionButton);

        // withdraw button
        this.withDraw = new Button();
        this.withDraw.Text = "Withdraw";
        this.withDraw.Click += (s, e) => MessageBox.Show("Hello from withdraw");
        this.withDraw.Location = new Point(0, 400);
        this.withDraw.Size = new Size(800, 50);

        this.Controls.Add(this.withDraw);

        // question text label
        this.questionText = new System.Windows.Forms.Label();
        this.questionText.Text = "Question will appear here";
        this.questionText.Location = new Point(0, 140);
        this.questionText.Size = new Size(600, 100);
        this.questionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.questionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        this.Controls.Add(this.questionText);

        // Answers Buttons
        this.answerC = new System.Windows.Forms.Button();
        this.answerC.Text = "Answer C";
        this.answerC.Click += (s, e) => MessageBox.Show("Hello from Answer c");
        this.answerC.Location = new Point(0, 330);
        this.answerC.Size = new Size(300, 50);

        this.Controls.Add(this.answerC);

        this.answerD = new System.Windows.Forms.Button();
        this.answerD.Text = "Answer D";
        this.answerD.Click += (s, e) => MessageBox.Show("Hello from Answer d");
        this.answerD.Location = new Point(300, 330);
        this.answerD.Size = new Size(300, 50);

        this.Controls.Add(this.answerD);

        this.answerA = new System.Windows.Forms.Button();
        this.answerA.Text = "Answer A";
        this.answerA.Click += (s, e) => MessageBox.Show("Hello from Answer a");
        this.answerA.Location = new Point(0, 280);
        this.answerA.Size = new Size(300, 50);
        this.Controls.Add(this.answerA);

        this.answerB = new System.Windows.Forms.Button();
        this.answerB.Text = "Answer B";
        this.answerB.Click += (s, e) => MessageBox.Show("Hello from Answer B");
        this.answerB.Location = new Point(300, 280);
        this.answerB.Size = new Size(300, 50);
        this.Controls.Add(this.answerB);
    }

    #endregion
}
