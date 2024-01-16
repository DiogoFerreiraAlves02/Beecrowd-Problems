using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = Console.ReadLine().Split();
            int a = input[0][0] - input[1][0];
            int b = input[0][1] - input[1][1];

            if(a*a+b*b == 5) Console.WriteLine("VALIDO");
            else Console.WriteLine("INVALIDO");
        }
    }   
} 

