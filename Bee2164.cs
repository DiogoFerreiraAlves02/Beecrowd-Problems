using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            int n = int.Parse(Console.ReadLine());

            double result = (Math.Pow((1+Math.Sqrt(5))/2, n)-Math.Pow((1-Math.Sqrt(5))/2, n))/Math.Sqrt(5);

            Console.WriteLine(string.Format("{0:0.0}",result));
        }   
    }   
} 
