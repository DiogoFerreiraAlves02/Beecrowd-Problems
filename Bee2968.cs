using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = Console.ReadLine().Split();
            int v = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            
            string msg = "";

            for(int i = 10; i<100; i+=10){
                msg+=$"{Math.Ceiling((double)v*n*i/100)} ";
            }

            Console.WriteLine(msg.TrimEnd());
        }
    }   
} 

