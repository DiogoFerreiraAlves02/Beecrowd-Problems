using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{string.Format("{0:0.0}",Math.Round(n/Math.Log(n),1))} {string.Format("{0:0.0}",Math.Round(1.25506*(n/Math.Log(n)),1))}");   
        }   
    }   
} 
