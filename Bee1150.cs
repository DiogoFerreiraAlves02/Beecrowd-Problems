using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int X = int.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int i = 0;
            int sum = 0;

            while(X >= Z){
                Z = int.Parse(Console.ReadLine());
            }
    
            while(sum<=Z){
                sum += X+i;
                i++;
            }

            Console.WriteLine(i);
        }
    }   
} 