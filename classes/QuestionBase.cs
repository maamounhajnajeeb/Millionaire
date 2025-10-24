namespace classes.QuestionBase
{
    public abstract class QuestionBase
    {
        public int Level { get; set; }
        public string Text { get; set; }
        
        public QuestionBase(int level, string text)
        {
            Level = level;
            Text = text;
        }

        public abstract bool IsCorrect(string answer);
    }
}
