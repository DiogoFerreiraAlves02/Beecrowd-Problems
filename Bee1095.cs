using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int j = 60;
            int i = 1;
            Console.WriteLine($"I={i} J={j}");
            while(j!=0){
                Console.WriteLine($"I={i += 3} J={j -= 5}");
            }
        }
    }   
} 