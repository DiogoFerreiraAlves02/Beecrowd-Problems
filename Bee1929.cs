using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);
            
            if(a < b+c && b < a+c && c < b+a) Console.WriteLine('S');
            else if(d < b+c && b < d+c && c < b+d) Console.WriteLine('S');
            else if(d < a+c && a < d+c && c < a+d) Console.WriteLine('S');
            else if(d < b+a && b < d+a && a < b+d) Console.WriteLine('S');
            else Console.WriteLine('N');
        }   
    }   
} 
