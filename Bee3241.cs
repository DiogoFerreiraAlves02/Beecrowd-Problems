using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string input;

            for(int i=0;i<n;i++){
                input = Console.ReadLine();
                
                if(input == "P=NP"){
                    Console.WriteLine("skipped");
                    continue;
                }
                
                int firstNumber = int.Parse(input.Split('+')[0]);
                int secondNumber = int.Parse(input.Split('+')[1]);
                Console.WriteLine(firstNumber+secondNumber);
            }
        }
    }   
} 

