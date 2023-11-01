using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            
            int[] par = new int[5];
            int[] impar = new int[5];
            int cntPar = 0;
            int cntImpar = 0;
            int n;

            for(int i = 0; i < 15; i++){
                n = int.Parse(Console.ReadLine());
                
                if(n%2 == 0){
                    if(cntPar == 4){
                        par[cntPar] = n;
                        for(int j = 0; j < 5; j++){
                            Console.WriteLine($"par[{j}] = {par[j]}");
                        }
                        cntPar = 0;
                    }
                    else{
                        par[cntPar] = n;
                        cntPar++;
                    }
                }
                else{
                    if(cntImpar == 4){
                        impar[cntImpar] = n;
                        for(int j = 0; j < 5; j++){
                            Console.WriteLine($"impar[{j}] = {impar[j]}");
                        }
                        cntImpar = 0;
                    }
                    else{
                        impar[cntImpar] = n;
                        cntImpar++;
                    }
                }
            }

            for(int i = 0; i < cntImpar; i++){
                Console.WriteLine($"impar[{i}] = {impar[i]}");
            }
            for(int i = 0; i < cntPar; i++){
                Console.WriteLine($"par[{i}] = {par[i]}");
            }
        }
    }   
} 