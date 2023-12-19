using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int N, M, L, CM, CL, A;      
            
            while(int.TryParse(Console.ReadLine(), out N)){
                string[] input1 = Console.ReadLine().Split(' ');
                M = int.Parse(input1[0]);
                L = int.Parse(input1[1]);

                int[,] marcusDeck = new int[M,N];
                int[,] leonardoDeck = new int[L,N];

                for(int i=0; i<M;i++){
                    string[] input2 = Console.ReadLine().Split(' ');
                    for(int j=0;j<N;j++){
                        marcusDeck[i,j] = int.Parse(input2[j]);
                    }
                }

                for(int i=0; i<L;i++){
                    string[] input2 = Console.ReadLine().Split(' ');
                    for(int j=0;j<N;j++){
                        leonardoDeck[i,j] = int.Parse(input2[j]);
                    }
                }

                input1 = Console.ReadLine().Split(' ');
                CM = int.Parse(input1[0])-1;
                CL = int.Parse(input1[1])-1;
                A = int.Parse(Console.ReadLine())-1;

                Console.WriteLine(marcusDeck[CM,A]>leonardoDeck[CL,A] ? "Marcos" : marcusDeck[CM,A] == leonardoDeck[CL,A] ? "Empate" : "Leonardo");
            }
        }  
    }   
} 

