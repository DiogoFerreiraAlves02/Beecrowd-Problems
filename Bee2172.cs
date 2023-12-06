using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            string[] inputs = new string[2];
            int x,m;
            
            while(true){
                inputs = Console.ReadLine().Split(' ');
                x = int.Parse(inputs[0]);
                m = int.Parse(inputs[1]);

                if(x==0 && m==0) break;

                Console.WriteLine(x*m);
            }
        }   
    }   
} 
