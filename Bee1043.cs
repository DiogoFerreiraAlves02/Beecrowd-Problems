using System;
using System.Globalization;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] stringNum = Console.ReadLine().Split(' ');

            double A = double.Parse(stringNum[0]);
            double B = double.Parse(stringNum[1]);
            double C = double.Parse(stringNum[2]);

            if((A+B) > C && (A+C) > B && (B+C) > A){
                Console.WriteLine("Perimetro = " + string.Format("{0:0.0}", A+B+C));
            }
            else{
                double s = (A+B+C)/2;
                Console.WriteLine("Area = " + string.Format("{0:0.0}", .5*(A+B)*C));
            }

        }
    }   
} 