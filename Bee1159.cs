using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int x = 0, sum;
            
            do{
                x = int.Parse(Console.ReadLine());
                if(x!=0){
                    if(x%2!=0) x++;
                    sum = 0;
                    for(int i = 0; i < 5; i++){
                        sum += x;
                        x+=2;
                    }
                    Console.WriteLine(sum);
                }
            } while(x!=0);
        }
    }   
} 