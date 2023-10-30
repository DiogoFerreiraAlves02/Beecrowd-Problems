using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int T = int.Parse(Console.ReadLine());
            int[] N = new int[1000];
            int aux = 0;
            for(int i = 0; i < N.Length; i++){
                if(aux == T) aux = 0;
                N[i] = aux++;
            }

            for (int i = 0; i < N.Length; i++){
                Console.WriteLine($"N[{i}] = {N[i]}");
            }
            
        }
    }   
} 