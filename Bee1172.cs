using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int[] X = new int[10];
            int n;

            for(int i = 0; i < X.Length; i++){
                n = int.Parse(Console.ReadLine());
                if(n<=0) X[i] = 1;
                else X[i] = n;
            }   

            for (int i = 0; i < X.Length; i++){
                Console.WriteLine($"X[{i}] = {X[i]}");
            }
        }
    }   
} 