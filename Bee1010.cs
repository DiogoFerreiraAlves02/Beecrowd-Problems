using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');
            double total1 = int.Parse(line1[1]) * double.Parse(line1[2]);
            double total2 = int.Parse(line2[1]) * double.Parse(line2[2]);
            Console.WriteLine($"VALOR A PAGAR: R$ {string.Format("{0:0.00}", total1+total2)}");
        }
    }   
} 