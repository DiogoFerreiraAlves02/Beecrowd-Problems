using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            string[] values = new string[2];

            for(int i=0; i<n; i++){
                values = Console.ReadLine().Split(' ');
                Console.WriteLine(int.Parse(values[0])+int.Parse(values[1]));
            }
                
        }
    }   
} 
