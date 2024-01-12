using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input1 = Console.ReadLine().Split();
            int C = int.Parse(input1[1]);

            string[] input2 = Console.ReadLine().Split();
            List<int> stickersNeeded = new List<int>();

            for(int i=0;i<input2.Length;i++){
                stickersNeeded.Add(int.Parse(input2[i])); 
            }
            
            string[] input3 = Console.ReadLine().Split();

            for(int i=0; i<input3.Length; i++){
                if(stickersNeeded.Contains(int.Parse(input3[i]))){
                    C--;
                    stickersNeeded.Remove(int.Parse(input3[i]));
                    if(stickersNeeded.Count==0) break;
                }
            }

            Console.WriteLine(C);
        }
    }   
} 

