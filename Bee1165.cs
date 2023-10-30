using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int N = int.Parse(Console.ReadLine());
            int X;
            bool prime;
            for(int i = 0; i < N; i++){
                X = int.Parse(Console.ReadLine());
                prime = true;

                for(int j = 2; j < X; j++){
                    if(X%j == 0){
                        prime = false;
                        break;
                    }
                }
                
                Console.WriteLine($"{X}{(prime ? "" : " nao")} eh primo");
            }   
        }
    }   
} 