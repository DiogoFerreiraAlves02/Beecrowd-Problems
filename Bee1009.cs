using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine());
            double sold = double.Parse(Console.ReadLine());
            Console.WriteLine($"TOTAL = R$ {string.Format("{0:0.00}", salary+sold*0.15)}");
        }
    }   
} 