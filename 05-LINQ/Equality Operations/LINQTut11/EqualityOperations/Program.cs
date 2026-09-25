using Shared;

namespace EqualityOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunMethod1(); //equal
            RunMethod2(); //equal
            RunMethod3(); //equal
            RunMethod4(); //not equal
            RunMethod5(); //equal

        }
        private static void RunMethod1()
        {
            var q1 = QuestionBank.PickOne();
            var q2 = QuestionBank.PickOne();
            var q3 = QuestionBank.PickOne();
            var quiz1 = new List<Question>(new[] { q1, q2, q3 });
            var quiz2 = new List<Question>(new[] { q1, q2, q3 });

            var equal = quiz1.SequenceEqual(quiz2); //عدد و عناصر

            Console.WriteLine($"quiz one and quiz two {(equal?"are":"are not")} equal");
        }
        private static void RunMethod2()
        {
            var fourQuestions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));
            var quiz1 = fourQuestions;
            var quiz2 = fourQuestions;

            var equal = quiz1.SequenceEqual(quiz2); //عدد و عناصر

            Console.WriteLine($"quiz one and quiz two {(equal ? "are" : "are not")} equal");
        }
        private static void RunMethod3()
        {
            var quiz1 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));
            var quiz2 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));

            var equal = quiz1.SequenceEqual(quiz2); //عدد و عناصر

            Console.WriteLine($"quiz one and quiz two {(equal ? "are" : "are not")} equal");
        }
        private static void RunMethod4()
        {
            var quiz1 = QuestionBank.Randomize(4);
            var quiz2 = QuestionBank.Randomize(4);

            var equal = quiz1.SequenceEqual(quiz2);
            // هنا اسئله عشوائيه يعني مش هيكونوا نفس قيم الل Property

            Console.WriteLine($"quiz one and quiz two {(equal ? "are" : "are not")} equal");
        }
        private static void RunMethod5()
        {
            List<int> list1 = new List<int> { 1, 2, 3 };
            List<int> list2 = new List<int> { 1, 2, 3 };

            var equal = list1.SequenceEqual(list2);

            Console.WriteLine($"quiz one and quiz two {(equal ? "are" : "are not")} equal");
        }
    }
}
