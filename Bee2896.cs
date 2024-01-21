using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int t = int.Parse(Console.ReadLine());
            string[] input = new string[2];
            int n,k;

            for(int i = 0; i < t; i++){
                input = Console.ReadLine().Split();
                n=int.Parse(input[0]);
                k=int.Parse(input[1]);
                Console.WriteLine((n%k)+(n/k));
            }
        }
    }   
} 

