using FunctionalProgramming;
using System;
namespace LINQTut01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();
            var femaleWithFNameStartsWiths01 = employees
                .Filter(e => e.Gender == "female" && e.FirstName.ToLowerInvariant().StartsWith("s"));

            femaleWithFNameStartsWiths01.Print("female With FName Starts With s / Filter");


            var femaleWithFNameStartsWiths02 = employees
                .Where(e => e.Gender == "female" && e.FirstName.ToLowerInvariant().StartsWith("s"));

            femaleWithFNameStartsWiths02.Print("female With FName Starts With s / Where");

        }
    }
}
