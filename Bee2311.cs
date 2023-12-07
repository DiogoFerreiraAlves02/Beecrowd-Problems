using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){   
            string[] inputs = new string[7];
            float d, highest, lowest,total;
            string name="";
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++){
                total = 0;
                name=Console.ReadLine();
                d = float.Parse(Console.ReadLine());
                inputs = Console.ReadLine().Split(' ');

                highest = float.Parse(inputs[0]);
                lowest = float.Parse(inputs[0]);

                for(int j=0; j<inputs.Length; j++){
                    total += float.Parse(inputs[j]);
                    if(float.Parse(inputs[j]) > highest) highest = float.Parse(inputs[j]);
                    if(float.Parse(inputs[j]) < lowest) lowest = float.Parse(inputs[j]);
                }  
                
                Console.WriteLine($"{name} {string.Format("{0:0.00}",Math.Round((total-highest-lowest) * d,2))}"); 
            }
        }   
    }   
} 

