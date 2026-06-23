using CSharp.ConsoleApp1;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;
namespace CSharp.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var d1 = new Date(28, 2, 2000);
            var d2 = new Date(2, 2000);
            var d3 = new Date(2000);

            Console.WriteLine(d1.DisplayDate());
            Console.WriteLine(d2.DisplayDate());
            Console.WriteLine(d3.DisplayDate());

        }
    }
    public class Date
    {
                                                     //  0  1   2    3  4    5  6    7  8   9  10   11 12
        private static readonly int[] DaysToMonth356 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DaysToMonth366 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private readonly int day = 01;
        private readonly int month = 01;
        private readonly int year = 01;
        public Date(int day,int month,int year)
        {
            var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] days = isLeap ? DaysToMonth366 : DaysToMonth356;
                if (day >= 1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
            }
            
        }
        public Date(int month,int year) : this(01, month, year) {}
        public Date(int year) :this(01,01,year) {}
        public string DisplayDate()
        {
            return $"{day.ToString().PadLeft(2, '0')} {month.ToString().PadLeft(2, '0')} {year.ToString().PadLeft(4, '0')}";
        }
    }
   
}



