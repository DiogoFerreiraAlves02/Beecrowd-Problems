using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = new string[2];
            int N;
            float avg, maxAvg;
            
            while(int.TryParse(Console.ReadLine(),out N)){
                maxAvg = 0;

                for(int i=0; i<N; i++){
                    input = Console.ReadLine().Split(' ');
                    avg = (float) int.Parse(input[1]) / int.Parse(input[0]);
                    if(avg > maxAvg){
                        Console.WriteLine(i+1);
                        maxAvg = avg;
                    }
                }

            }
        }  
    }   
} 

