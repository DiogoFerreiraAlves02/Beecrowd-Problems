using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            Console.WriteLine($"{a}{b}{c}");
            Console.WriteLine($"{b}{c}{a}");
            Console.WriteLine($"{c}{a}{b}");
            Console.WriteLine($"{(a.Length<=10 ? a : a.Substring(0,10))}{(b.Length<=10 ? b : b.Substring(0,10))}{(c.Length<=10 ? c : c.Substring(0,10))}");
        }
    }   
} 

