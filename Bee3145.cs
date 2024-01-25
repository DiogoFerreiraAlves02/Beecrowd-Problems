using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = Console.ReadLine().Split();
            Console.WriteLine("{0:F2}",double.Parse(input[1])/(double.Parse(input[0])+2));
        }
    }   
} 

