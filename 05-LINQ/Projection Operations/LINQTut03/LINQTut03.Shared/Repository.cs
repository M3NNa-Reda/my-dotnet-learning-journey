using System;
using System.Collections.Generic;
using System.Text;

namespace LINQTut03.Shared
{
    public class Repository
    {
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
        {
            new Employee
            {
                Id = 555,
                FirstName = "Menna",
                LastName = "Reda",
                Email = "menna.reda@example.com",
                Skills = new List<string> { "C#", "ASP.NET Core", "SQL Server", "EF Core" }
            },
            new Employee
            {
                Id = 101,
                FirstName = "Ahmed",
                LastName = "Ali",
                Email = "ahmed.ali@example.com",
                Skills = new List<string> { "C#", "SQL Server", "HTML", "CSS" }
            },
            new Employee
            {
                Id = 102,
                FirstName = "Sara",
                LastName = "Youssef",
                Email = "sara.y@example.com",
                Skills = new List<string> { "HR Management", "Communication", "Excel" }
            },
            new Employee
            {
                Id = 103,
                FirstName = "Omar",
                LastName = "Hassan",
                Email = "omar.h@example.com",
                Skills = new List<string> { "Python", "Data Analysis", "SQL Server", "PowerBI" }
            },
            new Employee
            {
                Id = 104,
                FirstName = "Nour",
                LastName = "El-Din",
                Email = "nour.e@example.com",
                Skills = new List<string> { "C#", "ASP.NET Core", "Angular", "Web API" }
            },
            new Employee
            {
                Id = 105,
                FirstName = "Mostafa",
                LastName = "Kamal",
                Email = "mostafa.k@example.com",
                Skills = new List<string> { "Financial Analysis", "Accounting", "Excel" }
            },
            new Employee
            {
                Id = 106,
                FirstName = "Laila",
                LastName = "Maged",
                Email = "laila.m@example.com",
                Skills = new List<string> { "SEO", "Content Creation", "Social Media" }
            },
            new Employee
            {
                Id = 107,
                FirstName = "Karim",
                LastName = "Tarek",
                Email = "karim.t@example.com",
                Skills = new List<string> { "C#", "JavaScript", "React", "HTML" }
            },
            new Employee
            {
                Id = 108,
                FirstName = "Mariam",
                LastName = "Amr",
                Email = "mariam.a@example.com",
                Skills = new List<string> { "Python", "Machine Learning", "SQL Server" }
            },
            new Employee
            {
                Id = 109,
                FirstName = "Youssef",
                LastName = "Sherif",
                Email = "youssef.s@example.com",
                Skills = new List<string> { "Recruiting", "Negotiation", "Public Speaking" }
            },
            new Employee
            {
                Id = 110,
                FirstName = "Dina",
                LastName = "Khaled",
                Email = "dina.k@example.com",
                Skills = new List<string> { "Budgeting", "Auditing", "Taxation" }
            }
        };
        }
    }
    }
