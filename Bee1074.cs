using System;
using System.Globalization;
using System.Collections.Generic;
namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int times = int.Parse(Console.ReadLine());
            string[] print = new string[times];
            int n = 0;
            for(int i = 0; i < times; i++){
                n = int.Parse(Console.ReadLine());
                if(n == 0) {
                    print[i] = "NULL";
                    continue;
                }
                print[i] = n%2 == 0 ? "EVEN " : "ODD ";
                print[i] += n>0 ? "POSITIVE" : "NEGATIVE";
            }
            foreach(string msg in print){
                Console.WriteLine(msg);
            }
            
        }
    }   
} 