using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            string[] inputs = inputs = Console.ReadLine().Split(' ');
            
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            string action = "";

            for(int i = 0; i < m; i++){
                action = Console.ReadLine();
                if(action == "fechou") n++;
                else n--;
            }

            Console.WriteLine(n);
        }   
    }   
} 
