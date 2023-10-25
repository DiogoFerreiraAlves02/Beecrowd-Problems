using System;
using System.Globalization;
using System.Collections.Generic;
namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = num1-1; i > num2 ; i--){
                if(i%2!=0) sum+=i;
            }
            Console.WriteLine(sum);
        }
    }   
} 