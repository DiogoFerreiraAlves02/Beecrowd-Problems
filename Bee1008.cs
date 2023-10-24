using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int number = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine($"NUMBER = {number}\nSALARY = U$ {string.Format("{0:0.00}", amount*hours)}");
        }
    }   
} 