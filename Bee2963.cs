using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            int maximum = 0, carlos = 0;
            
            for(int i=0; i<n;i++){
                int v = int.Parse(Console.ReadLine());
                if(v>maximum) {
                    maximum = v;
                    if(i==0) carlos = v;
                }
            }  
            
           Console.WriteLine(maximum==carlos?"S":"N"); 
        }
    }   
} 

