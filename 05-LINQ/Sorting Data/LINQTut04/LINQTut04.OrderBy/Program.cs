
using LINQTut04.Shared;

namespace LINQTut04.OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apricot", "orange", "banana", "mango", "apple" };

            var orderedFruits = fruits.OrderBy(x => x);

            orderedFruits.Print("Ordered Fruits Asc (Method Syntax)");


            var orderedFruitsQ = from f in fruits
                                  orderby f
                                  select f;

            orderedFruits.Print("Ordered Fruits Asc (Query Syntax)");




            var orderedFruitsD = fruits.OrderByDescending(x => x);

            orderedFruitsD.Print("Ordered Fruits Desc (Method Syntax)");


            var orderedFruitsQD = from f in fruits
                                 orderby f descending
                                 select f;

            orderedFruitsQD.Print("Ordered Fruits Desc (Query Syntax)");




            var orderedFruitsAscLength = fruits.OrderBy(x => x.Length);

            orderedFruitsAscLength.Print("Ordered Fruits Asc Length (Method Syntax)");


            var orderedFruitsAscLengthQ = from f in fruits
                                          orderby f.Length
                                          select f;

            orderedFruitsAscLengthQ.Print("Ordered Fruits Asc Length (Query Syntax)");



        }
    }
}
