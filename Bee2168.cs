using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            int n = int.Parse(Console.ReadLine()) + 1;
            string[] inputs = new string[n];
            int[,] block = new int[n,n];
            
            for(int i=0; i<n; i++){
                inputs = Console.ReadLine().Split(' ');
                for(int j=0; j<n; j++){
                    block[i,j] = int.Parse(inputs[j]);
                }
            }

            for(int i=0; i<n-1; i++){
                for(int j=0; j<n-1;j++){
                    if(block[i,j] + block[i,j+1] + block[i+1,j] + block[i+1,j+1]>=2){
                        Console.Write("S");
                    }
                    else Console.Write("U");
                }
                Console.WriteLine();
            }
        }   
    }   
} 
