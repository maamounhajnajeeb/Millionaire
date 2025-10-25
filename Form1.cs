using classes.GameManager;
using classes.Question;

namespace Millionaire;

public partial class Form1 : Form
{
    // create game manager instance
    private readonly GameManager gameManager;
    private Question currentQuestion;
    private int levelNumber = 0;
    private int money = 0;
    public Form1()
    {
        // initialize properties
        List<List<Question>> allQuestions = [];
        this.gameManager = new GameManager(allQuestions);

        InitializeComponent();
    }

    private void changeGameDependOnLevel()
    {
        // pick a random question for first level
        Question q = this.gameManager.GetRandomQuestion(this.levelNumber);

        // change the current question
        this.currentQuestion = q;

        // change level label number
        this.levelLabel.Text = $"Level: {this.levelNumber + 1}";

        // change current question money label
        this.currentMoneyLabel.Text = $"{this.currentMoneyLabel.Text[..9]}{this.QuestionsLevelLabels[this.levelNumber].Text}";

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
        this.answerB.Text = shuffledAnswers[1];
        this.answerC.Text = shuffledAnswers[2];
        this.answerD.Text = shuffledAnswers[3];
    }

    private void startButton_Click(object sender, EventArgs e)
    {
        // disable start game button
        this.startButton.Enabled = false;

        // load questions from file
        this.gameManager.LoadQuestions("bin\\Debug\\net9.0-windows\\questions.txt");

        // change game state depending on level
        this.changeGameDependOnLevel();
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
                // add money
                this.money += this.questionLevels[this.levelNumber];

                // display money to player
                MessageBox.Show($"Correct Answer, you won ${this.questionLevels[this.levelNumber]}");
                
                // change the value of the money label
                this.moneyLabel.Text = $"{moneyLabel.Text[..8]}{this.money}";

                // increase level by 1
                this.levelNumber += 1;

                // increase levelNumber and do next question logic
                this.changeGameDependOnLevel();
            }
            else
            {
                MessageBox.Show("Wrong Answer! Game Over.");
                // reset game
                // this.levelNumber = 0;
                // this.startButton.Enabled = true;
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
                // add money
                this.money += this.questionLevels[this.levelNumber];

                // display money to player
                MessageBox.Show($"Correct Answer, you won ${this.questionLevels[this.levelNumber]}");
                
                // change the value of the money label
                this.moneyLabel.Text = $"{moneyLabel.Text[..8]}{this.money}";

                // increase level by 1
                this.levelNumber += 1;

                // increase levelNumber and do next question logic
                this.changeGameDependOnLevel();
            }
            else
            {
                MessageBox.Show("Wrong Answer! Game Over.");
                // reset game
                // this.levelNumber = 0;
                // this.startButton.Enabled = true;
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
                // add money
                this.money += this.questionLevels[this.levelNumber];

                // display money to player
                MessageBox.Show($"Correct Answer, you won ${this.questionLevels[this.levelNumber]}");
                
                // change the value of the money label
                this.moneyLabel.Text = $"{moneyLabel.Text[..8]}{this.money}";

                // increase level by 1
                this.levelNumber += 1;

                // increase levelNumber and do next question logic
                this.changeGameDependOnLevel();
            }
            else
            {
                MessageBox.Show("Wrong Answer! Game Over.");
                // reset game
                // this.levelNumber = 0;
                // this.startButton.Enabled = true;
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
                // add money
                this.money += this.questionLevels[this.levelNumber];

                // display money to player
                MessageBox.Show($"Correct Answer, you won ${this.questionLevels[this.levelNumber]}");

                // change the value of the money label
                this.moneyLabel.Text = $"{moneyLabel.Text[..8]}{this.money}";

                // increase level by 1
                this.levelNumber += 1;

                // increase levelNumber and do next question logic
                this.changeGameDependOnLevel();
            }
            else
            {
                MessageBox.Show("Wrong Answer! Game Over.");
                // reset game
                // this.levelNumber = 0;
                // this.startButton.Enabled = true;
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
}
