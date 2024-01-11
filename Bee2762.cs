using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = Console.ReadLine().Split('.');
            Console.WriteLine($"{int.Parse(input[1])}.{int.Parse(input[0])}");
        }
    }   
} 

