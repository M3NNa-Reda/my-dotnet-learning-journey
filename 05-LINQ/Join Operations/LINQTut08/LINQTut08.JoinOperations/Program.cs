using LINQTut08.Shared;

namespace LINQTut08.JoinOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunJoin();
            RunGroupJoin();
            RunLeftJoin();
            RunRightJoin();
        }
        private static void RunJoin()
        {
            var employees = Repository.LoadEmployees();
            var department = Repository.LoadDepartment();
            //Method syntax
            var q01 = employees.Join(department,
                emp => emp.DepartmentId,
                dept => dept.Id,
                (emp, dept) => new EmployeeDto
                {
                    FullName = emp.FirstName +" "+ emp.LastName,
                    Department = dept.Name
                });

            foreach (var item in q01)
            {
                Console.WriteLine($"{item.FullName.PadRight(20)} | {item.Department}");
            }

            Console.WriteLine();
            //Query syntax
            var q02 = from emp in employees
                      join dept in department
                      on emp.DepartmentId equals dept.Id
                      select new EmployeeDto
                      {
                          FullName = emp.FirstName + " " + emp.LastName,
                          Department = dept.Name
                      };

            foreach (var item in q02)
            {
                Console.WriteLine($"{item.FullName.PadRight(20)} | {item.Department}");
            }

        }

        private static void RunGroupJoin()
        {
            var employees = Repository.LoadEmployees();
            var department = Repository.LoadDepartment();
            //Method syntax
            var q01 = department.GroupJoin(employees,
                dept => dept.Id,
                emp => emp.DepartmentId,
                (dept, emps) => new Group
                {
                    Department = dept.Name,
                    Employees = emps.Select(e => e.FirstName).ToList()
                });
            foreach (var group in q01)
            {
                Console.WriteLine($"-----------------  {group.Department}  -----------------");
                foreach (var name in group.Employees)
                {
                    Console.WriteLine(name);
                }
            }

            Console.WriteLine();
            //Query syntax
            var q02 = from dept in department
                      join emp in employees
                      on dept.Id equals emp.DepartmentId
                      into empGroup
                      select new Group
                      {
                          Department = dept.Name,
                          Employees = empGroup.Select(e => e.FirstName).ToList()
                      };

            foreach (var group in q02)
            {
                Console.WriteLine($"-----------------  {group.Department}  -----------------");
                foreach (var name in group.Employees)
                {
                    Console.WriteLine(name);
                }
            }
        }

        private static void RunLeftJoin()
        {
            var employees = Repository.LoadEmployees();
            var department = Repository.LoadDepartment();

            var q01 = department.LeftJoin(employees,
                dept => dept.Id,
                emp => emp.DepartmentId,
                (dept, emp) => new EmployeeDto
                {
                    FullName = emp != null ? emp.FirstName + " " + emp.LastName : "No Employees",
                    Department = dept.Name
                });
            foreach (var item in q01)
            {
                Console.WriteLine($"{item.FullName.PadRight(20)} | {item.Department}");
            }

            Console.WriteLine();
            
        }

        private static void RunRightJoin()
        {
            var employees = Repository.LoadEmployees();
            var department = Repository.LoadDepartment();
            
            var q01 = department.RightJoin(employees,
                dept => dept.Id,
                emp => emp.DepartmentId,
                (dept, emp) => new EmployeeDto
                {
                    FullName = emp.FirstName + " " + emp.LastName,
                    Department = dept != null ? dept.Name : "This employee does not have department"
                });
            foreach (var item in q01)
            {
                Console.WriteLine($"{item.FullName.PadRight(20)} | {item.Department}");
            }

            Console.WriteLine();

        }
    }
}
