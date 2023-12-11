using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){   
            int n = int.Parse(Console.ReadLine());
            string msg="";
            for(int i=0; i<n;i++){
                msg+= "a";
            }

            Console.WriteLine($"Feliz nat{msg}l!");
        }   
    }   
} 

