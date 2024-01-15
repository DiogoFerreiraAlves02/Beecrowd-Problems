using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] cups = Console.ReadLine().Split();

            Console.WriteLine(Array.IndexOf(cups,"1")+1);
        }
    }   
} 

