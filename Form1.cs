using classes.GameManager;
using classes.Question;

namespace Millionaire;

public partial class Form1 : Form
{
    // create game manager instance
    private readonly GameManager gameManager;
    private Question currentQuestion;
    private int firstBase, secondBase, money, levelNumber;
    public Form1()
    {
        // initialize properties
        List<List<Question>> allQuestions = [];
        this.gameManager = new GameManager(allQuestions);
        this.money = 0;
        this.levelNumber = 0;
        this.firstBase = 8;
        this.secondBase = 11;

        InitializeComponent();
    }

    private void changeGameDependOnLevel()
    {
        // check if player arrived to the end of the questions
        if (this.levelNumber == 15)
        {
            MessageBox.Show($"Congrats, You Won $1000000");
            this.Close();
        }

        // pick a random question for first level
        Question q = this.gameManager.GetRandomQuestion(this.levelNumber);

        // change the current question
        this.currentQuestion = q;

        // change level label number
        this.levelLabel.Text = $"Level: {this.levelNumber + 1}";

        // change current question money label
        this.currentMoneyLabel.Text = $"Current: {this.QuestionsLevelLabels[this.levelNumber].Text}";

        // change question text label
        this.questionText.Text = q.Text;

        // change question pointer color
        this.QuestionsLevelLabels[this.levelNumber].BackColor = Color.LightBlue;
        // remove past question pointer back color (if exists)
        if (this.levelNumber > 0)
        {
            this.QuestionsLevelLabels[this.levelNumber-1].BackColor = Control.DefaultBackColor;
        }

        // get shuffled answers
        List<string> shuffledAnswers = this.gameManager.GetShuffledAnswers(q);

        // change answers text
        this.answerA.Text = shuffledAnswers[0];
        this.answerA.Enabled = true;
        this.answerB.Text = shuffledAnswers[1];
        this.answerB.Enabled = true;
        this.answerC.Text = shuffledAnswers[2];
        this.answerC.Enabled = true;
        this.answerD.Text = shuffledAnswers[3];
        this.answerD.Enabled = true;
    }
    private void startButton_Click(object sender, EventArgs e)
    {
        // disable start game button
        this.startButton.Enabled = false;

        // load questions from file
        // this.gameManager.LoadQuestions("bin\\Debug\\net9.0-windows\\questions.txt");
        this.gameManager.LoadQuestions("questions.txt");

        // change game state depending on level
        this.changeGameDependOnLevel();
    }
    private void trueAnswer()
    {
        // get current question money
        int currentQuestionMoney = this.questionLevels[this.levelNumber];

        // add money
        this.money = currentQuestionMoney;

        // display money to player
        MessageBox.Show($"Correct Answer, you won ${currentQuestionMoney}");

        // change the value of the money label
        // this.moneyLabel.Text = $"{moneyLabel.Text[..8]}{this.money}";
        this.moneyLabel.Text = $"Money: ${this.money}";

        // increase level by 1
        this.levelNumber += 1;

        // increase levelNumber and do next question logic
        this.changeGameDependOnLevel();
    }
    private void wrongAnswer()
    {
        if (this.levelNumber >= this.secondBase)
        {
            this.money = 64000;
        }
        else if (this.levelNumber >= this.firstBase)
        {
            this.money = 8000;
        }
        else
        {
            this.money = 0;
        }
        MessageBox.Show($"Wrong Answer! Game Over. You Earned ${this.money}");
        this.Close();
    }
    private void answerAButton_Click(object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;

        DialogResult result = MessageBox.Show(
            $"Is {clickedButton.Text} your final answer?",
            "Confirmation",
            MessageBoxButtons.OKCancel
        );

        if (result == DialogResult.OK)
        {
            // check if its correct answer
            if (this.currentQuestion.IsCorrect(clickedButton.Text))
            {
                // do the success logic
                this.trueAnswer();
            }
            else
            {
                // do failure logic
                this.wrongAnswer();
            }
        }
    }

    private void answerBButton_Click(object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;

        DialogResult result = MessageBox.Show(
            $"Is {clickedButton.Text} your final answer?",
            "Confirmation",
            MessageBoxButtons.OKCancel
        );

        if (result == DialogResult.OK)
        {
            // check if its correct answer
            if (this.currentQuestion.IsCorrect(clickedButton.Text))
            {
                // do the success logic
                this.trueAnswer();
            }
            else
            {
                // do failure logic
                this.wrongAnswer();
            }
        }
    }

    private void answerCButton_Click(object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;

        DialogResult result = MessageBox.Show(
            $"Is {clickedButton.Text} your final answer?",
            "Confirmation",
            MessageBoxButtons.OKCancel
        );

        if (result == DialogResult.OK)
        {
            // check if its correct answer
            if (this.currentQuestion.IsCorrect(clickedButton.Text))
            {
                // do the success logic
                this.trueAnswer();
            }
            else
            {
                // do failure logic
                this.wrongAnswer();
            }
        }
    }

    private void answerDButton_Click(object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;

        DialogResult result = MessageBox.Show(
            $"Is {clickedButton.Text} your final answer?",
            "Confirmation",
            MessageBoxButtons.OKCancel
        );

        if (result == DialogResult.OK)
        {
            // check if its correct answer
            if (this.currentQuestion.IsCorrect(clickedButton.Text))
            {
                // do the success logic
                this.trueAnswer();
            }
            else
            {
                // do failure logic
                this.wrongAnswer();
            }
        }
    }
    private void withDraw_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            $"Are you sure you want to finish?",
            "Confirmation",
            MessageBoxButtons.OKCancel
        );

        if (result == DialogResult.OK)
        {
            MessageBox.Show($"You have withdrawn with ${this.money}!");
            this.Close();
        }
    }
    private void swiitchQuestionButton_Click(object sender, EventArgs e)
    {
        // disable switch question choice
        this.swiitchQuestionButton.Enabled = false;

        // do the question changing logic
        this.changeGameDependOnLevel();
    }

    private void fiftyFifty_Click(object sender, EventArgs e)
    {
        List<Button> answers =
        [
            this.answerA, this.answerB,
            this.answerC, this.answerD,
        ];

        int deletedAnswers = 0;
        for (int i = 0; i < 4; i++)
        {
            if (deletedAnswers == 2)
            {
                break;
            }

            Button answer = answers[i];
            if (!this.currentQuestion.IsCorrect(answer.Text))
            {
                // change wrong answer display state to be disabled
                answer.Enabled = false;
                // increase number of delete answers
                deletedAnswers += 1;
            }
        }

        // change 50:50 button state to be disabled
        this.fiftyFifty.Enabled = false;
    }
}
