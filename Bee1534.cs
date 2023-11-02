using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            
            int N;
            while (int.TryParse(Console.ReadLine(), out N)){
                int[,] array = new int[N, N];

                for (int i = 0; i < N; i++){
                    for (int j = 0; j < N; j++){
                        if (i == j) array[i,j] = 1;
                        if (i == N - j -1) array[i,j] = 2;
                        if (i != j && i != N-j-1)
                            array[i,j] = 3;
                    }
                } 

                for (int i = 0; i < N; i++){
                    for (int j = 0; j < N; j++){
                        Console.Write(array[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }   
} 
