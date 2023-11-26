using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            int c;
            for(int i=0; i<n;i++){
                c = int.Parse(Console.ReadLine());
                Console.WriteLine(c%2==0 ? "0" : "1");
            }
        }   
    }   
} 
