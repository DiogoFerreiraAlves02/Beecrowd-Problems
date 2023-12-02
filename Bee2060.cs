using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            int[] multiples = new int[4];

            int n = int.Parse(Console.ReadLine());
            string[] inputs = new string[n];
            inputs = Console.ReadLine().Split(' ');

            for(int i = 0; i <n; i++){
                if(int.Parse(inputs[i])%2==0) multiples[0]++;
                if(int.Parse(inputs[i])%3==0) multiples[1]++;
                if(int.Parse(inputs[i])%4==0) multiples[2]++;
                if(int.Parse(inputs[i])%5==0) multiples[3]++;
            }

            for(int i=0, j=2; i<4; i++, j++){
                Console.WriteLine($"{multiples[i]} Multiplo(s) de {j}");
            }
            
        }   
    }   
} 
