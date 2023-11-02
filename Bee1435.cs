using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            
            int N;
            while ((N = int.Parse(Console.ReadLine())) != 0){
                int[,] array = new int[N, N];

                for (int i = 0; i < N; i++){
                    for (int j = 0; j < N; j++){
                        int minValue = Math.Min(i, j);
                        minValue = Math.Min(minValue, N - 1 - i);
                        minValue = Math.Min(minValue, N - 1 - j);
                        array[i, j] = minValue + 1;
                    }
                }

                for (int i = 0; i < N; i++){
                    for (int j = 0; j < N; j++){
                        Console.Write(array[i, j].ToString().PadLeft(3));
                        if (j < N - 1){
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }   
} 
