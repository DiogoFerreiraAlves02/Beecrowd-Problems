using System;
using System.Globalization;
using System.Collections.Generic;
namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int num = int.Parse(Console.ReadLine());
            int cnt = 0;

            while(cnt != 6){
                if(num%2 != 0){
                    Console.WriteLine(num);
                    cnt++;
                }
                num++;
            }
            
        }
    }   
} 