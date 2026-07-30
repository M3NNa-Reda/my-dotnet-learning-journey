using Shared;

namespace ElementOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunElementAt();
            //RunFirst();
            //RunLast();
            RunSingle();
        }
        private static void RunElementAt()
        {
            var questions = QuestionBank.All;
            var questionAt10 = questions.ElementAt(10);
            //var questionAt300 = questions.ElementAt(300); //ArgumentOutOfRangeException
            var questionAt300 = questions.ElementAtOrDefault(300);
            Console.WriteLine(questionAt300); //null
            Console.WriteLine(questionAt10);
        }
        private static void RunFirst()
        {
            var questions = QuestionBank.All;
            var firstQuestion = questions.First(); //First question
            var firstQuestion02 = questions.FirstOrDefault(); //First question

            var firstQuestionmeetcodition = questions.First(q=>q.Title.Length>=100); //First question meet this condition

            //var firstQuestionmeetcodition02 = questions.First(q => q.Title.Length == 0); //InvalidOperationException
            var firstQuestionmeetcodition02 = questions.FirstOrDefault(q => q.Title.Length == 0);

            Console.WriteLine(firstQuestion);
            Console.WriteLine(firstQuestion02);

            Console.WriteLine(firstQuestionmeetcodition);
            Console.WriteLine(firstQuestionmeetcodition02); //null



        }
        private static void RunLast()
        {
            var questions = QuestionBank.All;
            var lastQuestion = questions.Last(); //Last question
            var lastQuestion02 = questions.LastOrDefault(); //Last question

            var lastQuestionmeetcodition = questions.Last(q => q.Title.Length >= 100); //last question meet this condition

            //var lastQuestionmeetcodition02 = questions.First(q => q.Title.Length == 0); //InvalidOperationException
            var lastQuestionmeetcodition02 = questions.LastOrDefault(q => q.Title.Length == 0);

            Console.WriteLine(lastQuestion);
            Console.WriteLine(lastQuestion02);

            Console.WriteLine(lastQuestionmeetcodition);
            Console.WriteLine(lastQuestionmeetcodition02); //null



        }
        private static void RunSingle()
        {
            var questions = QuestionBank.All;
            var question = questions.Single(x=>x.Title.Contains("#244"));
            //var question02 = questions.Single(x => x.Title.Contains("#245")); //InvalidOperationException more than one matching //ملهاش حل
            //var question03 = questions.Single(x => x.Title.Contains("#665")); //InvalidOperationException no matching  //حلها SingleOrDefault
            var question04 = questions.SingleOrDefault(x => x.Title.Contains("#665")); //No Exception

            Console.WriteLine(question04); //null

            var list=new List<string>();
            //var element = list.Single(); //InvalidOperationException: 'Sequence contains no elements'
            var element01 = list.SingleOrDefault();
            Console.WriteLine(element01);//No Exception


        }
    }
}
