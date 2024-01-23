using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string cup = Console.ReadLine();
            int movementType;

            for(int i=0;i<n;i++){
                movementType = int.Parse(Console.ReadLine());
                if(movementType == 1){
                    if(cup=="A") cup = "B";
                    else if(cup=="B") cup="A";
                }
                else if(movementType == 2){
                    if(cup=="B") cup = "C";
                    else if(cup=="C") cup="B";
                }
                else{
                    if(cup=="A") cup = "C";
                    else if(cup=="C") cup="A";
                }
            }
            Console.WriteLine(cup);
        }
    }   
} 

