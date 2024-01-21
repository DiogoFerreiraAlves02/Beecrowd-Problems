using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int[] portions = {300,1500,600,1000,150};
            int total = 0;

            for(int i = 0; i < portions.Length; i++){
                total += int.Parse(Console.ReadLine())*portions[i];
            }
            
            Console.WriteLine(total+225);
        }
    }   
} 

