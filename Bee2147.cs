using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            int n = int.Parse(Console.ReadLine());
            string input="";

            for(int i=0; i<n;i++){
                input = Console.ReadLine();
                Console.WriteLine(string.Format("{0:0.00}",input.Length*0.01));
            }
        }   
    }   
} 
