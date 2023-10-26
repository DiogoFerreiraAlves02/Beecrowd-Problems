using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int max = 0;
            int maxIndex = 0;
            int n = 0;
            for(int i = 1; i <= 100; i++){  
                n = int.Parse(Console.ReadLine());
                if(n>max){
                    max = n;
                    maxIndex = i;
                }
            }
            Console.WriteLine(max + "\n" + maxIndex);
            
        }
    }   
} 