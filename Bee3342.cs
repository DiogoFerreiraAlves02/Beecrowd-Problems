using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.Ceiling(Math.Pow(n,2)/2)} casas brancas e {Math.Floor(Math.Pow(n,2)/2)} casas pretas");
        }
    }   
} 

