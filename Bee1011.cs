using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double R = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"VOLUME = {string.Format("{0:0.000}", (4.0/3)*3.14159*Math.Pow(R,3))}");
        }
    }   
} 