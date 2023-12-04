using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            string name = Console.ReadLine();

            Console.WriteLine(name.Length<=80 ? "YES" : "NO");  
        }   
    }   
} 
