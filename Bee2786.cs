using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int l = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(l*c)+((l-1)*(c-1))}\n{((l-1)*2)+((c-1)*2)}");
        }
    }   
} 

