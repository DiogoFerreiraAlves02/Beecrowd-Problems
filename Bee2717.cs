using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            Console.WriteLine(n>= int.Parse(input[0])+int.Parse(input[1]) ? "Farei hoje!" : "Deixa para amanha!");
        }  
    }   
} 

