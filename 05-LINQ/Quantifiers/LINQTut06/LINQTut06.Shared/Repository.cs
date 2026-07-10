using System;
using System.Collections.Generic;
using System.Text;

namespace LINQTut06.Shared
{
    public class Repository
    {
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Index = 1,
                    EmployeeNo = "2017-FI-1343",
                    FirstName = "Menna",
                    LastName = "Reda",
                    Email = "menna.reda@example.com",
                    Salary = 31200m,
                    Skills = new List<string> { "C#", "ASP.NET Core", "SQL Server", "EF Core" }
                },
                new Employee
                {
                    Index = 2,
                    EmployeeNo = "2020-CS-1011",
                    FirstName = "Ahmed",
                    LastName = "Ali",
                    Email = "ahmed.ali@example.com",
                    Salary = 45000m,
                    Skills = new List<string> { "C#", "SQL Server", "HTML", "CSS" }
                },
                new Employee
                {
                    Index = 3,
                    EmployeeNo = "2017-HR-1022",
                    FirstName = "Sara",
                    LastName = "Youssef",
                    Email = "sara.y@example.com",
                    Salary = 28000m,
                    Skills = new List<string> { "HR Management", "Communication", "Excel" }
                },
                new Employee
                {
                    Index = 4,
                    EmployeeNo = "2021-IS-1033",
                    FirstName = "Omar",
                    LastName = "Hassan",
                    Email = "omar.h@example.com",
                    Salary = 35000m,
                    Skills = new List<string> { "Python", "Data Analysis", "SQL Server", "PowerBI" }
                },
                new Employee
                {
                    Index = 5,
                    EmployeeNo = "2023-CS-1044",
                    FirstName = "Nour",
                    LastName = "El-Din",
                    Email = "nour.e@example.com",
                    Salary = 52000m,
                    Skills = new List<string> { "C#", "ASP.NET Core", "Angular", "Web API" }
                },
                new Employee
                {
                    Index = 6,
                    EmployeeNo = "2019-FI-1055",
                    FirstName = "Mostafa",
                    LastName = "Kamal",
                    Email = "mostafa.k@example.com",
                    Salary = 60000m,
                    Skills = new List<string> { "Financial Analysis", "Accounting", "Excel" }
                },
                new Employee
                {
                    Index = 7,
                    EmployeeNo = "2024-MK-1066",
                    FirstName = "Laila",
                    LastName = "Maged",
                    Email = "laila.m@example.com",
                    Salary = 25000m,
                    Skills = new List<string> { "SEO", "Content Creation", "Social Media" }
                },
                new Employee
                {
                    Index = 8,
                    EmployeeNo = "2025-CS-1077",
                    FirstName = "Karim",
                    LastName = "Tarek",
                    Email = "karim.t@example.com",
                    Salary = 32000m,
                    Skills = new List<string> { "C#", "JavaScript", "React", "HTML" }
                },
                new Employee
                {
                    Index = 9,
                    EmployeeNo = "2021-IS-1088",
                    FirstName = "Mariam",
                    LastName = "Amr",
                    Email = "mariam.a@example.com",
                    Salary = 41000m,
                    Skills = new List<string> { "Python", "Machine Learning", "SQL Server" }
                },
                new Employee
                {
                    Index = 10,
                    EmployeeNo = "2023-HR-1099",
                    FirstName = "Youssef",
                    LastName = "Sherif",
                    Email = "youssef.s@example.com",
                    Salary = 27000m,
                    Skills = new List<string> { "Recruiting", "Negotiation", "Public Speaking" }
                },
                new Employee
                {
                    Index = 11,
                    EmployeeNo = "2026-FI-1100",
                    FirstName = "Dina",
                    LastName = "Khaled",
                    Email = "dina.k@example.com",
                    Salary = 55000m,
                    Skills = new List<string> { "Budgeting", "Auditing", "Taxation" }
                }
            };
        }
    }
    }
