using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int b = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());
            g = g % 2 == 0 ? g : g-1;

            Console.WriteLine(g/2 <= b ? "Amelia tem todas bolinhas!" : $"Faltam {g/2-b} bolinha(s)");
        }
    }   
} 

