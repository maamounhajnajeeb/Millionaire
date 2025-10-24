namespace classes.GameManager
{
    using System.Collections.Generic;
    using classes.Question;

    public class GameManager
    {
        private List<List<Question>> AllQuestions; // 15*5

        public GameManager(List<List<Question>> allQuestions)
        {
            AllQuestions = allQuestions;
        }

        public void LoadQuestions(string path)
        {
            // fill data within the AllQuestions array
        }

        // public Question GetRandomQuestion(int level)
        // {
        //     // Return a random question for the given level
        // }

        public void GetShuffledAnswers(Question q)
        {
            // Return shuffled answers for the given question
        }
    }
}