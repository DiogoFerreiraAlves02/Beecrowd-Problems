using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] inputs = new string[10]; 
            for(int i=0; i<10;i++){
                inputs[i] = Console.ReadLine();
            }
            Console.WriteLine($"{inputs[2]}\n{inputs[6]}\n{inputs[8]}");
        }
    }   
} 

