using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] Area = Console.ReadLine().Split(' ');
            double A = double.Parse(Area[0]);
            double B = double.Parse(Area[1]);
            double C = double.Parse(Area[2]);
            
            Console.WriteLine($"TRIANGULO: {string.Format("{0:0.000}", 0.5*C*A)}");
            Console.WriteLine($"CIRCULO: {string.Format("{0:0.000}", 3.14159*(C*C))}");
            Console.WriteLine($"TRAPEZIO: {string.Format("{0:0.000}", 0.5*C*(A+B))}");
            Console.WriteLine($"QUADRADO: {string.Format("{0:0.000}", B*B)}");
            Console.WriteLine($"RETANGULO: {string.Format("{0:0.000}", A*B)}");
            
        }
    }   
} 