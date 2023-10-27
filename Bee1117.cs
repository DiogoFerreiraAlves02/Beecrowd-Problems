using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double n = 0.0;
            double sum = 0;
            int cnt = 0;

            while(true){
                if(cnt == 2) break;
                n = double.Parse(Console.ReadLine());
                if(n < 0 || n > 10){
                    Console.WriteLine("nota invalida");
                    continue;
                }
                sum += n;
                cnt++;
            }
            Console.WriteLine("media = " + sum/2);
        }
    }   
} 