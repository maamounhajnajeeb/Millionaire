namespace classes.GameManager
{
    using System.Collections.Generic;
    using classes.Question;

    public class GameManager
    {
        private List<List<Question>> AllQuestions; // 15*5
        private Random Rand;

        public GameManager(List<List<Question>> allQuestions)
        {
            AllQuestions = allQuestions;
            Rand = new Random();
        }
        
        public void LoadQuestions(string path)
        {
            StreamReader fr;
            string fullPath = Path.Combine(AppContext.BaseDirectory, path);
            try 
            {
                //create StreamReader object
                fr = new StreamReader(fullPath);
                // fr = new StreamReader(path); 
                
                string content;
                for (int i = 0; i < 15; i++)
                {
                    AllQuestions.Add(new List<Question>());
                    string levelHeader = fr.ReadLine(); // read level header

                    for (int j = 0; j < 5; j++)
                    {
                        content = fr.ReadLine();

                        string[] fullQuestion = content.Split(";");
                        string questionText = fullQuestion[0];
                        string rightAnswer = fullQuestion[1];
                        string[] wrongAnswers = fullQuestion[2..fullQuestion.Length];

                        Question q = new Question(i + 1, questionText, rightAnswer, wrongAnswers);
                        AllQuestions[i].Add(q);
                    }
                    string endLine = fr.ReadLine(); // read blank end line
                } 

                fr.Close();
            
            } 
            catch (Exception e) { Console.WriteLine(e.Message); } 
        }

        public Question GetRandomQuestion(int level)
        {
            return AllQuestions[level][Rand.Next(0, 5)];
        }

        public List<string> GetShuffledAnswers(Question q)
        {
            List<string> answers = new List<string>();

            // pick three wrong answers randmly
            for (int i = 0; i < 3; i++)
            {
                int randIndex = Rand.Next(0, q.WrongAnswers.Length);
                string wrongAnswer = q.WrongAnswers[randIndex];

                // ensure no duplicates
                while (answers.Contains(wrongAnswer))
                {
                    randIndex = Rand.Next(0, q.WrongAnswers.Length);
                    wrongAnswer = q.WrongAnswers[randIndex];
                }

                answers.Add(wrongAnswer);
            }

            // add correct answer at a random index
            int correctAnswerIndex = Rand.Next(0, 4);
            answers.Insert(correctAnswerIndex, q.CorrectAnswer);

            return answers;
        }
    }
}