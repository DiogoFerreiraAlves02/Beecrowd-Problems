using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine((n/24.0*(n*n*n - 6*n*n + 23*n - 18)) + 1);
        }
    }   
} 

