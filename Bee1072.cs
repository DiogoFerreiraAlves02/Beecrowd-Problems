using System;
using System.Globalization;
using System.Collections.Generic;
namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int cases = int.Parse(Console.ReadLine());
            int num = 0;
            int dentro = 0;
            int fora = 0;
            for(int i = 0; i < cases; i++){
                num = int.Parse(Console.ReadLine());
                if(num >= 10 && num <= 20) dentro++;
                else fora++;
            }
            Console.WriteLine(dentro + " in\n" + fora + " out");
        }
    }   
} 