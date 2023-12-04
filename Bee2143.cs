using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            int t,n,total;

            while(true){
                t = int.Parse(Console.ReadLine());

                if(t == 0) break;

                for(int i = 0;i<t;i++){
                    n = int.Parse(Console.ReadLine());

                    if(n%2==0) total = n*2-2;
                    else total = n*2-1;

                    Console.WriteLine(total);
                }                      
            }
        }   
    }   
} 
