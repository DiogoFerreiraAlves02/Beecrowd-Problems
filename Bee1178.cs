using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            decimal x = decimal.Parse(Console.ReadLine());
            decimal[] N = new decimal[100];
            N[0] = x;

            for (int i = 1; i < N.Length; i++){
                N[i] = N[i-1]/2;
            }

            for(int i = 0; i < N.Length; i++){
                Console.WriteLine($"N[{i}] = {decimal.Round(N[i],4)}");
            }
            
        }
    }   
} 