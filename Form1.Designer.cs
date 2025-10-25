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
    private System.Windows.Forms.Button questionLevel1;
    private System.Windows.Forms.Button questionLevel2;
    private System.Windows.Forms.Button questionLevel3;
    private System.Windows.Forms.Button questionLevel4;
    private System.Windows.Forms.Button questionLevel5;
    private System.Windows.Forms.Button questionLevel6;
    private System.Windows.Forms.Button questionLevel7;
    private System.Windows.Forms.Button questionLevel8;
    private System.Windows.Forms.Button questionLevel39;
    private System.Windows.Forms.Button questionLevel10;
    private System.Windows.Forms.Button questionLevel11;
    private System.Windows.Forms.Button questionLevel12;
    private System.Windows.Forms.Button questionLevel13;
    private System.Windows.Forms.Button questionLevel14;
    private System.Windows.Forms.Button questionLevel15;
    private List<System.Windows.Forms.Label> QuestionsLevelLabels;
    private int[] questionLevels;
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
        this.currentMoneyLabel.Text = "Current: $0";
        this.currentMoneyLabel.Location = new Point(360, 100);
        this.Controls.Add(this.currentMoneyLabel);

        // money label
        this.moneyLabel = new System.Windows.Forms.Label();
        this.moneyLabel.Text = "Money: $0";
        this.moneyLabel.Location = new Point(185, 100);
        this.Controls.Add(this.moneyLabel);
        
        // level label
        this.levelLabel = new System.Windows.Forms.Label();
        this.levelLabel.Text = "Level: 0";
        this.levelLabel.Location = new Point(10, 100);
        this.Controls.Add(this.levelLabel);

        // 50:50 choice button
        this.fiftyFifty = new System.Windows.Forms.Button();
        this.fiftyFifty.Text = "50:50";
        this.fiftyFifty.Click += (s, e) => MessageBox.Show("Hello from 50:50");
        this.fiftyFifty.Location = new Point(0, 250);
        this.fiftyFifty.Size = new Size(300, 25);
        this.Controls.Add(this.fiftyFifty);

        // switch question choice button
        this.swiitchQuestionButton = new System.Windows.Forms.Button();
        this.swiitchQuestionButton.Text = "Switch Question";
        this.swiitchQuestionButton.Click += (s, e) => MessageBox.Show("Hello from switch questoin");
        this.swiitchQuestionButton.Location = new Point(300, 250);
        this.swiitchQuestionButton.Size = new Size(300, 25);
        this.Controls.Add(this.swiitchQuestionButton);

        // withdraw button
        this.withDraw = new Button();
        this.withDraw.Text = "Withdraw";
        this.withDraw.Click += new System.EventHandler(withDraw_Click);
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
        this.answerA = new System.Windows.Forms.Button();
        this.answerA.Text = "Answer A";
        this.answerA.Click += new System.EventHandler(answerAButton_Click);
        this.answerA.Location = new Point(0, 280);
        this.answerA.Size = new Size(300, 50);
        this.Controls.Add(this.answerA);

        this.answerB = new System.Windows.Forms.Button();
        this.answerB.Text = "Answer B";
        this.answerB.Click += new System.EventHandler(answerBButton_Click);
        this.answerB.Location = new Point(300, 280);
        this.answerB.Size = new Size(300, 50);
        this.Controls.Add(this.answerB);

        this.answerC = new System.Windows.Forms.Button();
        this.answerC.Text = "Answer C";
        this.answerC.Click += new System.EventHandler(answerCButton_Click);
        this.answerC.Location = new Point(0, 330);
        this.answerC.Size = new Size(300, 50);
        this.Controls.Add(this.answerC);

        this.answerD = new System.Windows.Forms.Button();
        this.answerD.Text = "Answer D";
        this.answerD.Click += new System.EventHandler(answerDButton_Click);
        this.answerD.Location = new Point(300, 330);
        this.answerD.Size = new Size(300, 50);
        this.Controls.Add(this.answerD);

        // Question Levels Labels
        int[] questionLevels =
        {
            100, 200, 300, 500, 1000,
            2000, 4000, 8000, 16000, 32000,
            64000, 125000, 250000, 500000, 1000000
        };
        this.questionLevels = questionLevels;
        
        Label QuestionLevelLabel15 = new System.Windows.Forms.Label();
        QuestionLevelLabel15.Text = $"${questionLevels[14]}";
        QuestionLevelLabel15.Location = new Point(620, 90 + 19 * (1 + 14));
        QuestionLevelLabel15.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel15);
        
        Label QuestionLevelLabel14 = new System.Windows.Forms.Label();
        QuestionLevelLabel14.Text = $"${questionLevels[13]}";
        QuestionLevelLabel14.Location = new Point(620, 90 + 19 * (1 + 13));
        QuestionLevelLabel14.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel14);
        
        Label QuestionLevelLabel13 = new System.Windows.Forms.Label();
        QuestionLevelLabel13.Text = $"${questionLevels[12]}";
        QuestionLevelLabel13.Location = new Point(620, 90 + 19 * (1 + 12));
        QuestionLevelLabel13.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel13);

        Label QuestionLevelLabel12 = new System.Windows.Forms.Label();
        QuestionLevelLabel12.Text = $"${questionLevels[11]}";
        QuestionLevelLabel12.Location = new Point(620, 90 + 19 * (1 + 11));
        QuestionLevelLabel12.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel12);

        Label QuestionLevelLabel11 = new System.Windows.Forms.Label();
        QuestionLevelLabel11.Text = $"${questionLevels[10]}";
        QuestionLevelLabel11.Location = new Point(620, 90 + 19 * (1 + 10));
        QuestionLevelLabel11.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel11);
        
        Label QuestionLevelLabel10 = new System.Windows.Forms.Label();
        QuestionLevelLabel10.Text = $"${questionLevels[9]}";
        QuestionLevelLabel10.Location = new Point(620, 90 + 19 * (1 + 9));
        QuestionLevelLabel10.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel10);
        
        Label QuestionLevelLabel9 = new System.Windows.Forms.Label();
        QuestionLevelLabel9.Text = $"${questionLevels[8]}";
        QuestionLevelLabel9.Location = new Point(620, 90 + 19 * (1 + 8));
        QuestionLevelLabel9.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel9);
        
        Label QuestionLevelLabel8 = new System.Windows.Forms.Label();
        QuestionLevelLabel8.Text = $"${questionLevels[7]}";
        QuestionLevelLabel8.Location = new Point(620, 90 + 19 * (1 + 7));
        QuestionLevelLabel8.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel8);
        
        Label QuestionLevelLabel7 = new System.Windows.Forms.Label();
        QuestionLevelLabel7.Text = $"${questionLevels[6]}";
        QuestionLevelLabel7.Location = new Point(620, 90 + 19 * (1 + 6));
        QuestionLevelLabel7.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel7);

        Label QuestionLevelLabel6 = new System.Windows.Forms.Label();
        QuestionLevelLabel6.Text = $"${questionLevels[5]}";
        QuestionLevelLabel6.Location = new Point(620, 90 + 19 * (1 + 5));
        QuestionLevelLabel6.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel6);
        
        Label QuestionLevelLabel5 = new System.Windows.Forms.Label();
        QuestionLevelLabel5.Text = $"${questionLevels[4]}";
        QuestionLevelLabel5.Location = new Point(620, 90 + 19 * (1 + 4));
        QuestionLevelLabel5.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel5);

        Label QuestionLevelLabel4 = new System.Windows.Forms.Label();
        QuestionLevelLabel4.Text = $"${questionLevels[3]}";
        QuestionLevelLabel4.Location = new Point(620, 90 + 19 * (1 + 3));
        QuestionLevelLabel4.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel4);

        Label QuestionLevelLabel3 = new System.Windows.Forms.Label();
        QuestionLevelLabel3.Text = $"${questionLevels[2]}";
        QuestionLevelLabel3.Location = new Point(620, 90 + 19 * (1 + 2));
        QuestionLevelLabel3.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel3);
        
        Label QuestionLevelLabel2 = new System.Windows.Forms.Label();
        QuestionLevelLabel2.Text = $"${questionLevels[1]}";
        QuestionLevelLabel2.Location = new Point(620, 90 + 19 * (1 + 1));
        QuestionLevelLabel2.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel2);

        Label QuestionLevelLabel1 = new System.Windows.Forms.Label();
        QuestionLevelLabel1.Text = $"${questionLevels[0]}";
        QuestionLevelLabel1.Location = new Point(620, 90 + 19 * (1 + 0));
        QuestionLevelLabel1.Size = new Size(60, 19);
        this.Controls.Add(QuestionLevelLabel1);

        List<Label> QuestionsLevelLabels =
        [
            QuestionLevelLabel1, QuestionLevelLabel2, QuestionLevelLabel3, QuestionLevelLabel4,
            QuestionLevelLabel5, QuestionLevelLabel6, QuestionLevelLabel7, QuestionLevelLabel8,
            QuestionLevelLabel9, QuestionLevelLabel10, QuestionLevelLabel11, QuestionLevelLabel12,
            QuestionLevelLabel13, QuestionLevelLabel14, QuestionLevelLabel15,
        ];
        this.QuestionsLevelLabels = QuestionsLevelLabels;
    }

    #endregion
}
