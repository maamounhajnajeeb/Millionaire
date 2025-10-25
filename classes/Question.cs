namespace classes.Question
{
    using classes.QuestionBase;

    public class Question : QuestionBase
    {
        public string CorrectAnswer { get; set; }
        public string[] WrongAnswers { get; set; }

        public Question(
            int level,
            string text,
            string correctAnswer,
            string[] wrongAnswers
        )
            : base(level, text)
        {
            CorrectAnswer = correctAnswer;
            WrongAnswers = wrongAnswers;
        }

        public override bool IsCorrect(string answer)
        {
            return answer == CorrectAnswer;
        }
    }
}
