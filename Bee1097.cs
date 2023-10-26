using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int j = 7;
            for(int i = 1; i <= 9; i+=2){
                for(int x = 0; x < 3; x++){
                    Console.WriteLine($"I={i} J={j--}");
                }
                j = j+5;
            }
            
        }
    }   
} 