using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[3];

            for(int i=0; i<n;i++){
                input = Console.ReadLine().Split();
                Console.WriteLine(int.Parse(input[0])>=200 && int.Parse(input[0])<=300 && (int.Parse(input[1])>=50) && int.Parse(input[2])>=150?"Sim":"Nao");
            }   
        }
    }   
} 

