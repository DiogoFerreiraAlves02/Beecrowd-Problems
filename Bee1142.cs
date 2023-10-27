using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){

            int n = int.Parse(Console.ReadLine());
            int cnt = 1;

            for(int i=0; i < n; i++){
                Console.WriteLine($"{cnt} {cnt+1} {cnt+2} PUM");
                cnt+=4;
            }
        }
    }   
} 