using System;
using System.Globalization;
using System.Collections.Generic;
namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double num = 0;
            int cnt = 0;
            double sum = 0;
            for(int i = 0; i < 6; i++){
                num = double.Parse(Console.ReadLine());
                
                if(num>0) {
                    sum += num;
                    cnt++;
                }
            }
            Console.WriteLine($"{cnt} valores positivos\n{Math.Round(sum/cnt, 1)}");
        }
    }   
} 