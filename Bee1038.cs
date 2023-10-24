using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] products = Console.ReadLine().Split(' ');
            int X = int.Parse(products[0]);
            int Y = int.Parse(products[1]);
            double[] prices = {4.00, 4.50, 5.00, 2.00, 1.50};
            Console.WriteLine("Total: R$ " + string.Format("{0:0.00}",prices[X-1]*Y));
            
        }
    }   
} 