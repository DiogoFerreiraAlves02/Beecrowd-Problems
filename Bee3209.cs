using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string[] input;
            int total;

            for(int i = 0; i < n; i++){
                total=0;
                input = Console.ReadLine().Split();
                for(int j = 1; j <= int.Parse(input[0]); j++){
                    total+= int.Parse(input[j]);
                }
                Console.WriteLine(total-int.Parse(input[0])+1);
            }
        }
    }   
} 

