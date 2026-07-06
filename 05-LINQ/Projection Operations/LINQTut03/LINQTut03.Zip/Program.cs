using LINQTut03.Shared;

namespace LINQTut03.Zip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample01();
            RunExample02();

        }
        private static void RunExample01()
        {
            string[] colorName = { "Red", "Green", "Blue", "extra" };
            string[] colorHEX = { "FF0000", "00FF00", "0000FF" };
            var colors = colorName.Zip(colorHEX, (name, hex) => $"{name} ({hex})");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }

        private static void RunExample02()
        {
            var employees = Repository.LoadEmployees().ToArray();
            var firstThreeEmployees = employees[..3];
            var lastThreeEmployees = employees[^3..];

            var teams=firstThreeEmployees.Zip(lastThreeEmployees,(first,last)=>
            $"{first.FirstName} with {last.FirstName}");

            // using query syntax

            var teams02= from team in firstThreeEmployees.Zip(lastThreeEmployees)
                         select $"{team.First.FirstName} with {team.Second.FirstName}";

            foreach (var team in teams02)
            {
                Console.WriteLine(team);
            }

        }
    }
}
