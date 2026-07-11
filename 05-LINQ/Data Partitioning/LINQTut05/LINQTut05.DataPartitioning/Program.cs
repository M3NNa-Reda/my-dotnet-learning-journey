using LINQTut05.Shared;

namespace LINQTut05.DataPartitioning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunSkipDemo();
            RunTakeDemo();
            RunChunkDemo();
        }

        public static void RunSkipDemo()
        {
            var emps=Repository.LoadEmployees();
            var q1 = emps.Skip(5);
            q1.Print("Skip First 5 Employees");


            var q2 = emps.SkipWhile(x => x.Salary != 25000m);
            q2.Print("Skip While Salary does not equal 25000");

            var q3=emps.SkipLast(5);
            q3.Print("Skip Last 5 Employees");

        }

        public static void RunTakeDemo()
        {
            var emps = Repository.LoadEmployees();
            var q1 = emps.Take(5);
            q1.Print("Take First 5 Employees");


            var q2 = emps.TakeWhile(x => x.Salary != 25000m);
            q2.Print("Take While Salary does not equal 25000");

            var q3 = emps.TakeLast(5);
            q3.Print("Take Last 5 Employees");

        }

        public static void RunChunkDemo()
        {
            var emps = Repository.LoadEmployees();
            var chunks = emps.Chunk(4).ToList(); //تقسيم لمجموعات كل مجموعة فيها 4 عناصر 

            for (int i = 0; i < chunks.Count; i++)
            {
                chunks[i].Print($"Chunk #{i + 1}");
            }

        }
    }
}
