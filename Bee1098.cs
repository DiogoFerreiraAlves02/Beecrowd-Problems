using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            
            for(double i = 0; i <= 2; i+=0.2){
                for(double j = 1; j <= 3; j++){
                    Console.WriteLine($"I={Math.Round(i,1)} J={Math.Round(j+i,1)}");
                }
            }
            
        }
    }   
} 