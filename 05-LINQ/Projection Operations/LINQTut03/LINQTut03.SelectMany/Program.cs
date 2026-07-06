using LINQTut03.Shared;

namespace LINQTut03.SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample01();
            RunExample02();
        }
        private static void RunExample01()
        {
            string[] sentences = {
                "I love asp.net core",
                "I like sql server also",
                "in general i love programming"
            };

            var Sentences = sentences.SelectMany(x => x.Split(' '));

            // using query syntax
            var result = from sentence in sentences
                          from word in sentence.Split(' ')
                          select word;

            foreach (var word in Sentences)
            {
                Console.WriteLine(word);
            }
        }
        private static void RunExample02()
        {
            var employees = Repository.LoadEmployees();

            var skills = employees.SelectMany(x => x.Skills).Distinct();

            // using query syntax
            var result =(from employee in employees
                       from skill in employee.Skills
                       select skill).Distinct();
            
            foreach (var skill in result)
            {
                Console.WriteLine(skill);
            }
        }

    }
}
