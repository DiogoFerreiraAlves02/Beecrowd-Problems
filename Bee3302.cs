using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            int num;
            for(int i = 1; i <= n; i++){
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"resposta {i}: {num}");
            }   
        }
    }   
} 

