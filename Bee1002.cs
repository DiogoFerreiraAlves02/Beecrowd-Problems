using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double R = double.Parse(Console.ReadLine());
            double n = 3.14159d;
            Console.WriteLine($"A={string.Format("{0:0.0000}", n*Math.Pow(R,2))}");
        }
    }   
} 
