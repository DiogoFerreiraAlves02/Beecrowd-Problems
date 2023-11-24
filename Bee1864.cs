using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string quote = "LIFE IS NOT A PROBLEM TO BE SOLVED, BUT A REALITY TO BE EXPERIENCED.";
            char[] quoteArray = quote.ToCharArray();
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++){
                Console.Write(quoteArray[i]);
            }
            Console.Write("\n");
        }   
    }   
} 
