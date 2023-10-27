using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] reads = new string[2];
            int x, y;
            List<String> results = new List<String>();

            while(true){
                reads = Console.ReadLine().Split(' ');
                x = int.Parse(reads[0]);
                y = int.Parse(reads[1]);
                if(x == y) break;
                results.Add(x > y ? "Decrescente" : "Crescente");   
            }
            foreach(var result in results) Console.WriteLine(result);
        }
    }   
} 