using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int tourists = 0, jeeps = 0;
            string[] input;
            
            while(true){
                input = Console.ReadLine().Split(' ');
                if(input[0] == "ABEND") break;
                if(input[0] == "SALIDA"){
                    tourists += int.Parse(input[1]);
                    jeeps++;
                }
                else{
                    tourists -= int.Parse(input[1]);
                    jeeps--;
                }
            }
            
            Console.WriteLine(tourists+"\n"+jeeps);
        }  
    }   
} 

