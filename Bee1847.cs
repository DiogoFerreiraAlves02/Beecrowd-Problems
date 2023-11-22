using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] answers = Console.ReadLine().Split(' ');
            int a = int.Parse(answers[0]);
            int b = int.Parse(answers[1]);
            int q = 0;
            for(int r = 0; r < Math.Abs(b); r++){
                if((a-r)%b == 0){
                    q = (int)((a-r)/b);
                    Console.WriteLine($"{q} {r}");
                    break;
                } 
            }
            
        }
    }   
} 
