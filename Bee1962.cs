using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            int t;

            for(int i = 0; i < n; i++){
                t = int.Parse(Console.ReadLine());
                if(t<2015) Console.WriteLine(2015-t + " D.C.");
                else{
                    Console.WriteLine(t-2015+1 + " A.C.");
                }
            }

        }   
    }   
} 
