using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int l = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(l%2!=0 && c%2!=0) Console.WriteLine("1");
            else if(l%2==0 && c%2==0) Console.WriteLine("1");
            else Console.WriteLine("0");
        }
    }   
} 

