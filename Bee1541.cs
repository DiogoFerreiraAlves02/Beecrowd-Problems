using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] inputs = new string[3];
            while(true){
                
                inputs = Console.ReadLine().Split(' ');
                
                int A = int.Parse(inputs[0]);
                if(A==0) break;

                int B = int.Parse(inputs[1]);
                int C = int.Parse(inputs[2]);
                
                Console.WriteLine((int)Math.Sqrt((A*B)/(C/100.0)));
            }  
        }
    }   
} 
