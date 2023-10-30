using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int N = int.Parse(Console.ReadLine());
            int X, sum;

            for(int i = 0; i < N; i++){
                sum = 0;
                X = int.Parse(Console.ReadLine());

                for(int j = 1; j < X; j++){
                    if(X%j == 0) sum+=j;
                }
                Console.WriteLine($"{X}{(X == sum ? "" : " nao")} eh perfeito");
            }   
        }
    }   
} 