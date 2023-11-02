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
                        if (i == j) array[i,j] = 1;
                        if (i < j)
                            array[i,j] = j - i + 1;
                        if (i > j)
                            array[i,j] = i - j + 1;
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
