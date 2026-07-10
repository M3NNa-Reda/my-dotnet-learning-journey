using LINQTut06.Shared;

namespace LINQTut06.Quantifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunAnyDemo();
            RunAllDemo();
            RunContainDemo();
        }
        public static void RunAnyDemo()
        {
            var emps = Repository.LoadEmployees();            
            var q1 = emps.Any(x => x.FirstName.StartsWith("men", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"There is an employee with name starts with \"men\" ? {q1}");

            var q2 = emps.Any(x => x.Salary < 10000m);
            Console.WriteLine($"There is an employee with salary less than 10000 ? {q2}");

            var q3 = emps.Any(x => x.Skills.Count == 1);
            Console.WriteLine($"There is an employee with one skill ? {q3}");

        }

        public static void RunAllDemo()
        {
            var emps = Repository.LoadEmployees();
            var q1 = emps.All(x => !string.IsNullOrWhiteSpace(x.Email));
            Console.WriteLine($"All employees has value for emali ? {q1}");

            var q2 = emps.All(x => x.Salary > 10000m);
            Console.WriteLine($"All employees with salary greater than 10000 ? {q2}");


            var q3 = emps.All(x => x.Skills.Any(s => s == "C#"));
            Console.WriteLine($"All employees has C# skill ? {q3}");
            
        }

        public static void RunContainDemo()
        {
            var emps = Repository.LoadEmployees();
            var q1 = emps.Any(x => x.FirstName.Contains("ss")); // Instance 
            Console.WriteLine($"There is an employee with name contain ss ? {q1}");

            var e = new Employee { Email = "menna.reda@example.com" };
            var q2 = emps.Contains(e); //Extension 
            Console.WriteLine($"Any employee object with this email ? {q2}");  //طبعا طبعا false عشان هنا referance type

            var q3 = emps.All(x => x.Skills.Contains("C#"));  //Extension
            Console.WriteLine($"All employees has C# skill ? {q3}");

        }
    }
}
