using System;
using System.Collections.Generic;
using System.Text;

namespace LINQTut08.Shared
{
    public class Repository
    {
        public static IEnumerable<Department> LoadDepartment()
        {
            return new List<Department>
            {
                new Department {Id=1,Name="CS"},
                new Department {Id=2,Name="IT"},
                new Department {Id=3,Name="Finance"},
                new Department {Id=4,Name="HR"},
                new Department {Id=5,Name="Marketing"}

            };
        }
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id=555,
                    FirstName="Menna",
                    LastName="Reda",
                    HireDate=new DateTime(2026,5,12),
                    Gender="female",
                    DepartmentId=1,
                    HasHealthInsurance=false,
                    HasPensionPlan=false,
                    Salary=31200m
                },
                new Employee
        {
            Id = 101,
            FirstName = "Ahmed",
            LastName = "Ali",
            HireDate = new DateTime(2020, 1, 15),
            Gender = "male",
            DepartmentId = 2,
            HasHealthInsurance = true,
            HasPensionPlan = true,
            Salary = 45000m
        },
        new Employee
        {
            Id = 102,
            FirstName = "Sara",
            LastName = "Youssef",
            HireDate = new DateTime(2022, 3, 20),
            Gender = "female",
            DepartmentId = 3,
            HasHealthInsurance = true,
            HasPensionPlan = false,
            Salary = 28000m
        },
        new Employee
        {
            Id = 103,
            FirstName = "Omar",
            LastName = "Hassan",
            HireDate = new DateTime(2021, 11, 1),
            Gender = "male",
            DepartmentId = 2,
            HasHealthInsurance = false,
            HasPensionPlan = true,
            Salary = 35000m
        },
        new Employee
        {
            Id = 104,
            FirstName = "Nour",
            LastName = "El-Din",
            HireDate = new DateTime(2023, 6, 10),
            Gender = "female",
            DepartmentId = 1,
            HasHealthInsurance = true,
            HasPensionPlan = true,
            Salary = 52000m
        },
        new Employee
        {
            Id = 105,
            FirstName = "Mostafa",
            LastName = "Kamal",
            HireDate = new DateTime(2019, 8, 25),
            Gender = "male",
            DepartmentId = 4,
            HasHealthInsurance = true,
            HasPensionPlan = true,
            Salary = 60000m
        },
        new Employee
        {
            Id = 106,
            FirstName = "Laila",
            LastName = "Maged",
            HireDate = new DateTime(2024, 2, 14),
            Gender = "female",
            DepartmentId = 2,
            HasHealthInsurance = false,
            HasPensionPlan = false,
            Salary = 25000m
        },
        new Employee
        {
            Id = 107,
            FirstName = "Karim",
            LastName = "Tarek",
            HireDate = new DateTime(2025, 5, 5),
            Gender = "male",
            DepartmentId = 1,
            HasHealthInsurance = true,
            HasPensionPlan = false,
            Salary = 32000m
        },
        new Employee
        {
            Id = 108,
            FirstName = "Mariam",
            LastName = "Amr",
            HireDate = new DateTime(2021, 4, 18),
            Gender = "female",
            DepartmentId = 2,
            HasHealthInsurance = true,
            HasPensionPlan = true,
            Salary = 41000m
        },
        new Employee
        {
            Id = 109,
            FirstName = "Youssef",
            LastName = "Sherif",
            HireDate = new DateTime(2023, 9, 30),
            Gender = "male",
            DepartmentId = 3,
            HasHealthInsurance = false,
            HasPensionPlan = false,
            Salary = 27000m
        },
        new Employee
        {
            Id = 110,
            FirstName = "Dina",
            LastName = "Khaled",
            HireDate = new DateTime(2026, 1, 1),
            Gender = "female",
            DepartmentId = 4,
            HasHealthInsurance = true,
            HasPensionPlan = true,
            Salary = 55000m
        }
            };
        }

        
    }
 }
