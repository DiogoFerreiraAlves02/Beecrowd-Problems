using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            double a = 234.345;
            double b = 45.698;

            Console.WriteLine(string.Format("{0:0.000000}",a) + " - " + string.Format("{0:0.000000}",b));
            Console.WriteLine(string.Format("{0:0}",a) + " - " + string.Format("{0:0}",b));
            Console.WriteLine(string.Format("{0:0.0}",a) + " - " + string.Format("{0:0.0}",b));
            Console.WriteLine(string.Format("{0:0.00}",Math.Truncate(a * 100) / 100) + " - " + string.Format("{0:0.00}",b));
            Console.WriteLine(string.Format("{0:0.000}",a) + " - " + string.Format("{0:0.000}",b));
            Console.WriteLine(string.Format("{0:0.000000e+00}",a) + " - " + string.Format("{0:0.000000e+00}",b));
            Console.WriteLine(string.Format("{0:0.000000E+00}",a) + " - " + string.Format("{0:0.000000E+00}",b));
            Console.WriteLine(string.Format("{0:0.000}",a) + " - " + string.Format("{0:0.000}",b));
            Console.WriteLine(string.Format("{0:0.000}",a) + " - " + string.Format("{0:0.000}",b));
            
        }
    }   
} 

