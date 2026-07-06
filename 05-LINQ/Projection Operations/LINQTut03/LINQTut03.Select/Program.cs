using LINQTut03.Shared;
using System.Linq;
namespace LINQTut03.Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample01();
            RunExample02();
            RunExample03();
        }
        private static void RunExample01()
        {
            List<string> words = new List<string> { "i", "love", "asp.net", "core" };
            var result1 = words.Select(x => x.ToUpper());

            // using query syntax
            //var result2=from w in words
            //            select w.ToUpper();

            foreach (var word in result1)
            {
                Console.WriteLine(word);
            }
        }

        private static void RunExample02()
        {
            List<int> numbers = new List<int> { 2, 3, 5, 7 };
            var result1 = numbers.Select(x => x * x);

            // using query syntax
            //var result2 = from n in numbers
            //              select n * n;

            foreach (var num in result1)
            {
                Console.WriteLine(num);
            }
        }

        private static void RunExample03()
        {
            var employees= Repository.LoadEmployees();

            var result = employees.Select(x => new EmployeeDto
            {
                Name = x.FirstName + " " + x.LastName,
                ToatalSkills = x.Skills.Count()
            });

            
            foreach (var e in result)
            {
                Console.WriteLine(e);
            }
        }

    }
}
