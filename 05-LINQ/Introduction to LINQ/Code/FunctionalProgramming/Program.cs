namespace FunctionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExtensionProcedural();
            RunExtensionFunctional01();
            RunExtensionFunctional02();
        }
        private static void RunExtensionProcedural()
        {
            var q1 = ExtnensionProcedural.GetEmployeesWithFirstNameStartsWith("ma");
            q1.Print("Employees With First Name Starts With ma");

            var q2 = ExtnensionProcedural.GetEmployeesWithSalaryGreaterThan(5000m);
            q2.Print("Employees With Salary Greater Than 5000");

            var q3 = ExtnensionProcedural.GetEmployeesByDepartment("IT");
            q3.Print("Employees In IT Department");

            var targetDate = new DateTime(2020, 1, 1);
            var q4 = ExtnensionProcedural.GetEmployeesHiredAfter(targetDate);
            q4.Print($"Employees Hired After {targetDate.ToShortDateString()}");

            
            var q5 = ExtnensionProcedural.GetEmployeesWithInsuranceAndNoPension();
            q5.Print("Employees With Health Insurance & No Pension Plan");
        }
        private static void RunExtensionFunctional01()
        {
            var employees = Repository.LoadEmployees();
            var q1 = employees.Filter(e => e.FirstName.ToLowerInvariant().StartsWith("ma"));
            q1.Print("Employees With First Name Starts With ma");

            var q2 = employees.Filter(e => e.Salary > 5000m);
            q2.Print("Employees With Salary Greater Than 5000");

            var q3 = employees.Filter(e => e.Department == "IT");
            q3.Print("Employees In IT Department");

            var targetDate = new DateTime(2020, 1, 1);
            var q4 = employees.Filter(e => e.HireDate > targetDate);
            q4.Print($"Employees Hired After {targetDate.ToShortDateString()}");


            var q5 = employees.Filter(e => e.HasHealthInsurance && !e.HasPensionPlan);
            q5.Print("Employees With Health Insurance & No Pension Plan");
        }
      
        private static void RunExtensionFunctional02()
        {
            var employees = Repository.LoadEmployees();
            
            var q1 = employees.Filter( e => e.FirstName.ToLowerInvariant().StartsWith("ma"));
            q1.Print("Employees With First Name Starts With ma");

            var q2 = employees.Filter( e => e.Salary > 5000m);
            q2.Print("Employees With Salary Greater Than 5000");

            var q3 = employees.Filter( e => e.Department == "IT");
            q3.Print("Employees In IT Department");

            var targetDate = new DateTime(2020, 1, 1);
            var q4 = employees.Filter( e => e.HireDate > targetDate);
            q4.Print($"Employees Hired After {targetDate.ToShortDateString()}");


            var q5 = employees.Filter( e => e.HasHealthInsurance && !e.HasPensionPlan);
            q5.Print("Employees With Health Insurance & No Pension Plan");
        }

    }

}
