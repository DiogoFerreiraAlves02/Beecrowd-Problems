using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            
            string[] inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);

            for(int i=1; i <= y; i++){
                
                if(i%x == 0) {
                    Console.Write(i+"\n");
                }
                else{
                    Console.Write(i+" ");
                }
            }
        }
    }   
} 