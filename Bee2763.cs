using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = Console.ReadLine().Split('.');
            
            Console.WriteLine($"{input[0]}\n{input[1]}\n{input[2].Split('-')[0]}\n{input[2].Split('-')[1]}");
        }
    }   
} 

