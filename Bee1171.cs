using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            int[] appearances = new int[2000];
            int num;

            for(int i = 0; i < n; i++){
                num = int.Parse(Console.ReadLine());
                appearances[num-1]++;
            }       

            int cnt=0;
            for(int i=0; i<2000;i++){
                if(appearances[i]!=0){
                    Console.WriteLine($"{i+1} aparece {appearances[i]} vez(es)");
					cnt+=appearances[i];
				}
                if(cnt==n) break;
            }                     
        }
    }   
} 

