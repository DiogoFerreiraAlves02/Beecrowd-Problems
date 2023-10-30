using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int[] N = new int[10];
            int n = int.Parse(Console.ReadLine());
            N[0] = n;
            
            for(int i = 1; i < N.Length; i++){
                N[i] = N[i-1]*2;
            }   

            for (int i = 0; i < N.Length; i++){
                Console.WriteLine($"N[{i}] = {N[i]}");
            }
        }
    }   
} 