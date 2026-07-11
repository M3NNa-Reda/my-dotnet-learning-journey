using System;
using System.Collections.Generic;
using System.Text;

namespace LINQTut07.Shared
{
    public class Repository
    {
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
                    Department="CS",
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
            Department = "CS",
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
            Department = "HR",
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
            Department = "IS",
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
            Department = "CS",
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
            Department = "Finance",
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
            Department = "Marketing",
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
            Department = "CS",
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
            Department = "IS",
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
            Department = "HR",
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
            Department = "Finance",
            HasHealthInsurance = true,
            HasPensionPlan = true,
            Salary = 55000m
        }
            };
        }
    }
    }
