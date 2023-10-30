using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            string[] inputs = new string[2];
            int X, Y, sum, cnt;
            for(int i = 0; i < n; i++){
                sum = 0;
                cnt = 0;
                inputs = Console.ReadLine().Split(' ');
                X = int.Parse(inputs[0]);
                Y = int.Parse(inputs[1]);
                if(X%2==0) X++;
                while(cnt < Y){
                    sum += X;
                    cnt++;
                    X+=2;
                }
                Console.WriteLine(sum);
            }
        }
    }   
} 