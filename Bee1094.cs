using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int times = int.Parse(Console.ReadLine());
            string[] inputs;
            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;

            for(int i = 0; i < times; i++){  
                inputs = Console.ReadLine().Split(' ');
                switch(inputs[1]){
                    case "C":
                        coelhos += int.Parse(inputs[0]);
                        break;
                    case "R":
                        ratos += int.Parse(inputs[0]);
                        break;
                    case "S":
                        sapos += int.Parse(inputs[0]);
                        break;
                }
            }
            double total = coelhos+ratos+sapos;
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + string.Format("{0:P2}", coelhos/total));
            Console.WriteLine("Percentual de ratos: " + string.Format("{0:P2}", ratos/total));
            Console.WriteLine("Percentual de sapos: " + string.Format("{0:P2}", sapos/total));
        }
    }   
} 