using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[2];
            for(int i=0; i<n;i++){
                input = Console.ReadLine().Split(' ');
                Console.WriteLine(input[0].ToLower() == "thor" ? "Y" : "N");
            }
        }   
    }   
} 
