using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){   
            string[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            if(a==b || a==c || b==c) {
                Console.WriteLine("S");
                return;
            }
            else if(a == b + c || b == a + c || c == a + b) {
                Console.WriteLine("S");
                return;
            }
            Console.WriteLine("N");
        }   
    }   
} 
