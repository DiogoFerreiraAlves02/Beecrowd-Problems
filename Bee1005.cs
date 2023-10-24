using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double MEDIA = (A*3.5+B*7.5)/11;
            Console.WriteLine($"MEDIA = {string.Format("{0:0.00000}", MEDIA)}");
        }
    }   
} 
