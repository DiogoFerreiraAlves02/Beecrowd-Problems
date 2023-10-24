using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] values = Console.ReadLine().Split(' ');
            double A = double.Parse(values[0]);
            double B = double.Parse(values[1]);
            double C = double.Parse(values[2]);

            if(A == 0 || B*B - 4*A*C < 0){
                Console.WriteLine("Impossivel calcular");
            }
            else{
                double R1 = ((-B) + Math.Sqrt(B*B-4*A*C))/(2*A);
                double R2 = ((-B) - Math.Sqrt(B*B-4*A*C))/(2*A);
                Console.WriteLine($"R1 = {string.Format("{0:0.00000}",R1)}\nR2 = {string.Format("{0:0.00000}",R2)}");
            }
           
        }
    }   
} 