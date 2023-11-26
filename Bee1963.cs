using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] inputs = Console.ReadLine().Split(' ');

            double a = double.Parse(inputs[0]);
            double b = double.Parse(inputs[1]);
            double result = (b-a)/a * 100;
            Console.WriteLine(result.ToString("F2")+"%");
        }   
    }   
} 
