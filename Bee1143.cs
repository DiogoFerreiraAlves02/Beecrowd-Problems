using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){

            int n = int.Parse(Console.ReadLine());

            for(int i=1; i <= n; i++){
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }
        }
    }   
} 