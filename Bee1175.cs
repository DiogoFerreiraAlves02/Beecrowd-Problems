using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int[] N = new int[20];
            int n;

            for(int i = 0; i < N.Length; i++){
                n = int.Parse(Console.ReadLine());
                N[i] = n;
            }   

            Array.Reverse(N);

            for (int i = 0; i < N.Length; i++){
                Console.WriteLine($"N[{i}] = {N[i]}");
            }
        }
    }   
} 