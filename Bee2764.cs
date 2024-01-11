using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = Console.ReadLine().Split('/');
            
            Console.WriteLine($"{input[1]}/{input[0]}/{input[2]}\n{input[2]}/{input[1]}/{input[0]}\n{input[0]}-{input[1]}-{input[2]}");
        }
    }   
} 

