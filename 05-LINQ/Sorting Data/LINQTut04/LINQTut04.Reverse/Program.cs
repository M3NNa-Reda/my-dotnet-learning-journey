using LINQTut04.Shared;

namespace LINQTut04.Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apricot", "orange", "banana", "mango", "apple" };

            var reversedOrder = fruits.Reverse();
            reversedOrder.Print("reversedOrder");
        }
    }
}
