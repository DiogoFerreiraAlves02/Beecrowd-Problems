using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input;
            while(true){
                try{
                    input = Console.ReadLine().Split();
                    if(string.IsNullOrEmpty(input[0])) break;
                }
                catch{break;}
                
                Console.WriteLine(ulong.Parse(input[0])^ulong.Parse(input[1]));
            }
        }
    }   
} 

