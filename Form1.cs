namespace Millionaire;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
        var withDraw = new Button();
        withDraw.Text = "Withdraw";
        withDraw.Click += (s, e) => MessageBox.Show("Hello from .NET!");
        withDraw.Location = new Point(0, 400);
        withDraw.Size = new Size(800, 50);

        this.Controls.Add(withDraw);

        var AnswerC = new Button();
        AnswerC.Text = "Answer C";
        AnswerC.Click += (s, e) => MessageBox.Show("Hello from Answer c");
        AnswerC.Location = new Point(0, 330);
        AnswerC.Size = new Size(300, 50);

        this.Controls.Add(AnswerC);

        var AnswerD = new Button();
        AnswerD.Text = "Answer D";
        AnswerD.Click += (s, e) => MessageBox.Show("Hello from Answer d");
        AnswerD.Location = new Point(300, 330);
        AnswerD.Size = new Size(300, 50);

        this.Controls.Add(AnswerD);

        var AnswerA = new Button();
        AnswerA.Text = "Answer A";
        AnswerA.Click += (s, e) => MessageBox.Show("Hello from Answer a");
        AnswerA.Location = new Point(0, 280);
        AnswerA.Size = new Size(300, 50);

        this.Controls.Add(AnswerA);

        var AnswerB = new Button();
        AnswerB.Text = "Answer B";
        AnswerB.Click += (s, e) => MessageBox.Show("Hello from Answer B");
        AnswerB.Location = new Point(300, 280);
        AnswerB.Size = new Size(300, 50);

        this.Controls.Add(AnswerB);

        var SwitchQuestion = new Button();
        SwitchQuestion.Text = "SwitchQuestion";
        SwitchQuestion.Click += (s, e) => MessageBox.Show("Hello from SwitchQuestion");
        SwitchQuestion.Location = new Point(300, 250);
        SwitchQuestion.Size = new Size(300, 25);

        this.Controls.Add(SwitchQuestion);

        var FiftyFifty = new Button();
        FiftyFifty.Text = "FiftyFifty";
        FiftyFifty.Click += (s, e) => MessageBox.Show("Hello from 50:50");
        FiftyFifty.Location = new Point(0, 250);
        FiftyFifty.Size = new Size(300, 25);

        this.Controls.Add(FiftyFifty);

        // question text label
        var QuestionText = new System.Windows.Forms.Button();
        QuestionText.Text = "Question will appear here";
        QuestionText.Location = new Point(0, 150);
        QuestionText.Size = new Size(600, 100);

        this.Controls.Add(QuestionText);

        // level label
        var LevelLabel = new System.Windows.Forms.Label();
        LevelLabel.Text = "Level: ";
        LevelLabel.Location = new Point(10, 100);
        // LevelLabel.Size = new Size(600, 100);

        this.Controls.Add(LevelLabel);

        // money label
        var MoneyLabel = new System.Windows.Forms.Label();
        MoneyLabel.Text = "Money: $";
        MoneyLabel.Location = new Point(185, 100);
        
        this.Controls.Add(MoneyLabel);

        // current money label
        var CurrentMoneyLabel = new System.Windows.Forms.Label();
        CurrentMoneyLabel.Text = "Current Money: $";
        CurrentMoneyLabel.Location = new Point(360, 100);

        this.Controls.Add(CurrentMoneyLabel);

        // start button
        var Startbutton = new System.Windows.Forms.Button();
        Startbutton.Text = "Start Game";
        Startbutton.Click += (s, e) => MessageBox.Show("Start Game");
        Startbutton.Location = new Point(620, 0);
        Startbutton.Size = new Size(180, 100);

        this.Controls.Add(Startbutton);

        // question levels labels
        for (int i = 0; i < 15; i++)
        {
            var QuestionLevelLabel = new System.Windows.Forms.Label();
            QuestionLevelLabel.Text = "$100";
            QuestionLevelLabel.Location = new Point(620, 90 + 19 *(1+i));
            QuestionLevelLabel.Size = new Size(40, 19);

            this.Controls.Add(QuestionLevelLabel);
        }
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hello from .NET!");
    }
}
