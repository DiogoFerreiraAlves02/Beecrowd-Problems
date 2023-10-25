using System;
using System.Globalization;
using System.Collections.Generic;
namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double num = 0;
            int cnt = 0;

            for(int i = 0; i < 5; i++){
                num = double.Parse(Console.ReadLine());
                if(num % 2 == 0) cnt++;
            }
            Console.WriteLine($"{cnt} valores pares");
        }
    }   
} 