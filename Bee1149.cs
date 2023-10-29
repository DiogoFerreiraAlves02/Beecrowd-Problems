using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int N = int.Parse(input[1]);
            int sum = 0;
            int cnt = 1; 
            while(N <= 0){
                cnt++;
                N = int.Parse(input[cnt]);
            }
    
            for(int i = 0; i < N;i++){
                sum += A + i;
            }

            Console.WriteLine(sum);
        }
    }   
} 