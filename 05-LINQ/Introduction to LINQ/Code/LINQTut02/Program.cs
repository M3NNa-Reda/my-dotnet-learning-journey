using FunctionalProgramming;
using System.Collections;

namespace LINQTut02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var collection = new ArrayList { 1, true, "menna",DateTime.Now };

            var evennumbers = numbers.Where(x => x % 2 == 0);

            numbers.Add(10);
            numbers.Add(12);
            numbers.Remove(4);

            foreach (var n in evennumbers)
            {
                Console.Write($" {n} ");
            }
            // 2 4 6 8 or 2  6  8  10  12
            // 2  6  8  10  12
            //  مش بتتنفذ غير لما ابدا اعمل اللوبwhere جملة -> deferred execution
            // deferred execution: it will be executed when iterating in a loop
            // or when the collection will be iterated in some other way.

            // مقدرش اطبق عليها ال LINQ
            // لازم يكون IEnumerable<T>
            //var blabla = collection.Where(x => x % 2 == 0);

            //الطرق المختلف اللي ممكن اكتب بيها الكويري

            var evenNumbersUsingExtensionWhere =
                numbers.Where(x => x % 2 == 0);

            var evenNumbersUsingEnumerableWhereMethod =
                Enumerable.Where(numbers, x => x % 2 == 0);

            var evenNumbersUsingQuerySyntax =
                from n in numbers
                where n % 2 == 0
                select n;

            //  Enumerable.Where(numbers, x => x % 2 == 0); كلهم بيترجموا الى 
            evenNumbersUsingExtensionWhere.Print("evenNumbersUsingExtensionWhere");
            evenNumbersUsingEnumerableWhereMethod.Print("evenNumbersUsingEnumerableWhereMethod");
            evenNumbersUsingQuerySyntax.Print("evenNumbersUsingQuerySyntax");


        }



    }
    
    
}
