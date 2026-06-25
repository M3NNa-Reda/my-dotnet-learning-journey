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
            var stock = new Stock("Amazon");
            stock.Price = 100;
            stock.OnPriceChanged += Stock_OnPriceChanged; //اقدر استبدل الميثود ب Lambda Expression  
            stock.StockPriceChangeBy(-0.05m);
            stock.StockPriceChangeBy(0.05m);
            stock.StockPriceChangeBy(0.00m);
            stock.OnPriceChanged -= Stock_OnPriceChanged; // unsubscriber
            stock.StockPriceChangeBy(0.05m);



            Console.ReadKey();
        }

        private static void Stock_OnPriceChanged(Stock stock, decimal oldprice)
        {
            if (stock.Price > oldprice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if(stock.Price < oldprice) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine($"{stock.Name} | {stock.Price}");
        }
    }

    public delegate void StockPriceChangeHandler(Stock stock, decimal oldprice);
        
        public class Stock
        {
            private string name;
            private decimal price;
            public string Name => this.name;
            public decimal Price
            {
                get => price;
                set => price = value;
            }
            public event StockPriceChangeHandler OnPriceChanged;
            public Stock(string stockname)
            {
                this.name = stockname;
            }

            public void StockPriceChangeBy(decimal percent) 
            {
                decimal oldprice = this.Price;
                price += Math.Round(price * percent, 2);
                if(OnPriceChanged!=null) // Make sure there is Subscriber
            {
                    OnPriceChanged(this, oldprice); //firing /publishing the event
                }
            }
        }    
   
    
}



