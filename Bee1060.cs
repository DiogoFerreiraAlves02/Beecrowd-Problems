using System;
using System.Globalization;
using System.Collections.Generic;
namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int cnt = 0;
            
            for(int i = 0; i < 6; i++){
                double num = double.Parse(Console.ReadLine());
                if(num>0) cnt++;
            }

            Console.WriteLine(cnt + " valores positivos");
        }
    }   
} 