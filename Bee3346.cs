using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = Console.ReadLine().Split();
            double result = (100.00+double.Parse(input[0]))*(double.Parse(input[1])/100.00+1)-100.00;
            Console.WriteLine("{0:F6}",result);
        }
    }   
} 

