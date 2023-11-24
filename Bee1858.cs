using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int indexMenor = 1;
            int menor = int.Parse(input[0]);

            for(int i=1; i < N; i++){
                if(int.Parse(input[i]) < menor) {
                    menor = int.Parse(input[i]);
                    indexMenor = i+1;
                }
            }

            Console.WriteLine(indexMenor);

        }   
    }   
} 
