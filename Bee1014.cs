using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
                      
            Console.WriteLine($"{string.Format("{0:0.000}", X/Y)} km/l");            
        }
    }   
} 