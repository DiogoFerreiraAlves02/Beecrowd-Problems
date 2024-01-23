using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[2];
            int grant = 0,expenses=0;
            
            for(int i = 0; i < n; i++){
                input = Console.ReadLine().Split(' ');
                if(input[0] == "G") expenses+=int.Parse(input[1]);
                else grant+=int.Parse(input[1]);
            }
            Console.WriteLine(expenses>grant?"NAO VAI TER CORTE, VAI TER LUTA!":"A greve vai parar.");
        }
    }   
} 

