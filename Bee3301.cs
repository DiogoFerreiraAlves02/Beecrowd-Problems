using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] ages = Console.ReadLine().Split();    
            int h = int.Parse(ages[0]);
            int z = int.Parse(ages[1]);
            int l = int.Parse(ages[2]);

            if((z>h && z<l) || (z<h && z>l) ) Console.WriteLine("zezinho");
            else if((h>l && h<z) || (h<l && h>z)) Console.WriteLine("huguinho");
            else Console.WriteLine("luisinho");
        }
    }   
} 

