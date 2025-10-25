namespace Millionaire;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        // question levels labels
        string[] questionLevels =
        {
            "$100", "$200", "$300", "$500", "$1000",
            "$2000", "$4000", "$8000", "$16000", "$32000",
            "$64000", "$125000", "$250000", "$500000", "$1000000"
        };
        for (int i = 0; i < 15; i++)
        {
            var QuestionLevelLabel = new System.Windows.Forms.Label();
            QuestionLevelLabel.Text = questionLevels[14-i];
            QuestionLevelLabel.Location = new Point(620, 90 + 19 *(1+i));
            QuestionLevelLabel.Size = new Size(60, 19);

            this.Controls.Add(QuestionLevelLabel);
        }
    }
    
    private void startButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hello from .NET!");
    }
}
