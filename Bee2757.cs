using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"A = {a}, B = {b}, C = {c}");
            Console.WriteLine($"A = {a,10}, B = {b,10}, C = {c,10}");
            Console.WriteLine($"A = {(a<0 ? string.Format("{0:000000000}",a) : string.Format("{0:0000000000}",a))}, B = {(b<0 ? string.Format("{0:000000000}",b) : string.Format("{0:0000000000}",b))}, C = {(c<0 ? string.Format("{0:000000000}",c) : string.Format("{0:0000000000}",c))}");
            Console.WriteLine($"A = {a,-10}, B = {b,-10}, C = {c,-10}");
        }
    }   
} 

