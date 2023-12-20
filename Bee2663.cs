using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] scores = new int[1000];
            int count = 0;

            for (int i = 0; i < N; i++){
                scores[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(scores);
            Array.Reverse(scores);

            for(int i=0; i<N; i++){
                count++;
                if(count==K){
                    for(int j=i+1;j<N;j++){
                        if(scores[i]!=scores[j]) break;
                        count++;
                    }
                    break;
                }
            }

            Console.WriteLine(count);
        }  
    }   
} 

