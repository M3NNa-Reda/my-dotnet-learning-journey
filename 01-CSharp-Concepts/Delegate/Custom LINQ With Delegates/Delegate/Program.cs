namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 4, 7, 10, 15, 20 };
            List<int> evens = numbers.Filter(n => n % 2 == 0);
            Console.Write("Result: ");
            foreach (var item in evens)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n--------------\n");
            List<Employee> staff = GetEmployees();
            List<string> names = staff.Transform(e => e.Name);
            Console.Write("Result: ");
            foreach (var item in names)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n--------------\n");
            var sortedBySalary = staff.SortBy(e => e.BasicSalary);
            foreach (var item in sortedBySalary)
            {
                Console.WriteLine(item);
            }
            var sortedByName = staff.SortBy(e => e.Name);
            //var sortedByName = staff.SortBy(delegate(Employee e) { return e.Name; });
            Console.WriteLine("\n--------------\n");
            foreach (var item in sortedByName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n--------------\n");

            Console.WriteLine("Pipeline Verification");
            List<string> result = staff.Filter(s => s.NetSalary >= 3500)
                .SortBy(s => s.NetSalary)
                .Transform(s => $"Employee: [{s.Name}] | Net: [{s.NetSalary:C0}]")
                .ToFreshList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------\n");
            bool check;
            check = staff.HasAny(s => s.Bonus > 1000);
            Console.WriteLine($"Has Any High Bonus (> 1000): {check}");
            check = staff.MatchAll(s => s.BasicSalary >= 2000);
            Console.WriteLine($"Match All Basic >= 2000: {check}");
            var c = staff.CountWhere(s => s.Deductions == 0);
            Console.WriteLine($"Count with Zero Deductions: {c}");
            var ff = staff.FindFirst(s => s.Name.StartsWith('M'));
            Console.WriteLine($"First Employee starting with 'M': {ff?.Name}");

            Console.WriteLine("\n--------------\n");

            var sortedBySalaryDESC = staff.SortByDescending(e => e.BasicSalary);
            foreach (var item in sortedBySalaryDESC)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------\n");

            var res = staff.TakeFirst(3);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n--------------\n");

            List<Employee> list = staff.ToFreshList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------\n");

            var l = new List<int>();
            var l01 = l.HasAny();
            Console.WriteLine(l01);
            l.Add(1);
            var l11 = l.HasAny();
            Console.WriteLine(l11);

            var l02 = staff.HasAny();
            Console.WriteLine(l02);

            var l03 = staff.HasAny(s => s.Name == "Menna");
            Console.WriteLine(l03);
            var l13 = staff.HasAny(s => s.Name == "Mohamed");
            Console.WriteLine(l13);

            Console.WriteLine("\n--------------\n");

            var isMatch = staff.MatchAll(s => s.Name.Length > 1);
            Console.WriteLine(isMatch);
            isMatch = staff.MatchAll(s => s.BasicSalary < 7000);
            Console.WriteLine(isMatch);

            Console.WriteLine("\n--------------\n");

            var count = staff.CountWhere();
            Console.WriteLine(count);
            count = staff.CountWhere(s => s.Id > 3);
            Console.WriteLine(count);

            Console.WriteLine("\n--------------\n");

            var r = staff.FindFirst(x => x.Name == "Menna");
            Console.WriteLine(r == null ? "No match" : r);
            r = staff.FindFirst(x => x.Id == 2);
            Console.WriteLine(r == null ? "No match" : r);
            r = staff.FindFirst(x => x.Id == 222);
            Console.WriteLine(r == null ? "No match" : r);
            
        }
        static List<Employee> GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Menna", BasicSalary = 5000m, Bonus = 1000m, Deductions = 500m },
                new Employee { Id = 2, Name = "Momen", BasicSalary = 4000m, Bonus = 800m,  Deductions = 400m },
                new Employee { Id = 3, Name = "Mai",   BasicSalary = 8000m, Bonus = 1200m, Deductions = 600m },
                new Employee { Id = 4, Name = "Ahmed", BasicSalary = 3000m, Bonus = 500m,  Deductions = 300m },
                new Employee { Id = 5, Name = "Mona",  BasicSalary = 9000m, Bonus = 1500m, Deductions = 700m }
            };
            return employees;
        }
        
    }
}
