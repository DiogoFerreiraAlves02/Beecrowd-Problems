using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int T = int.Parse(Console.ReadLine());
            int PA, PB, anos;
            double G1, G2;
            string[] inputs = new string[2];

            for(int i = 0; i < T; i++){
                anos = 0;
                inputs = Console.ReadLine().Split(' ');
                PA = int.Parse(inputs[0]);
                PB = int.Parse(inputs[1]);
                G1 = double.Parse(inputs[2]);
                G2 = double.Parse(inputs[3]);

                while(PA <= PB){
                    PA += (int)(PA*(G1/100));
                    PB += (int)(PB*(G2/100));
                    anos++;
                }
                Console.WriteLine(anos>100 ? "Mais de 1 seculo." : $"{anos} anos.");
            }   
        }
    }   
} 