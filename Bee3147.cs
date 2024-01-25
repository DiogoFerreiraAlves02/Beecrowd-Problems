using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(input[0])+int.Parse(input[1])+int.Parse(input[2])+int.Parse(input[5])> int.Parse(input[3])+int.Parse(input[4]) ? "Middle-earth is safe." : "Sauron has returned.");
        }
    }   
} 

