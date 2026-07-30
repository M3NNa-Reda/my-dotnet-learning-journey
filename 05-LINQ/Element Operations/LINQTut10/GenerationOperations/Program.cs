using Shared;

namespace GenerationOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunEmpty();
            RunDefaultIfEmpty();
            RunRange();
            RunRepeat();
        }
        private static void RunEmpty()
        {
            var questions01 = new List<Question>(); //empty list 
            //1
            //...
            //1000
            foreach (var question in questions01)
            {
                Console.WriteLine(question);
            }

            var questions02 = Enumerable.Empty<Question>(); //empty list //Deferred Execution
            //1
            //...
            //1000
            foreach (var question in questions02)
            {
                Console.WriteLine(question);
            }
        }
        private static void RunDefaultIfEmpty()
        {
            var questions = Enumerable.Empty<Question>();
            var question01 = questions.DefaultIfEmpty();
            var question02 = questions.DefaultIfEmpty(Question.Default);
            //مهمه في ال lift outer join

            question01.ToQuiz(); //null default value
            question02.ToQuiz(); //default value of question

        }
        private static void RunRange()
        {
            //int[] range2 = new int[10];
            //for (int i = 0;i<range2.Length;i++)
            //{
            //    range2[i] = i;
            //    Console.Write(range2[i] + " ");
            //}

            var range = Enumerable.Range(0, 10); //Deferred Execution
            foreach (var i in range)
            {
                Console.Write(i + " ");
            }
            var questions = QuestionBank.GetQuestionRange(range);
            questions.ToQuiz();
        }

        private static void RunRepeat()
        {
            var question = QuestionBank.PickOne();

            var questions = Enumerable.Repeat(question,10).ToList();
            // السؤال دا هيتكرر 10 مرات
            questions.ToQuiz();
            // هل دا سؤال واحد فعلا بنفس الرفرينس اه
            Console.WriteLine(ReferenceEquals(questions[0], questions[1]));  //True

        }
    }
}
