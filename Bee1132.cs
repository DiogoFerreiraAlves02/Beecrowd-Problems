using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());            
            int sum = 0;

            if(x > y){
                int aux = y;
                y = x;
                x = aux;
            }

            for(int i = x; i <= y; i++){
                if(i%13 != 0) sum += i;
            }

            Console.WriteLine(sum);
        }
    }   
} 