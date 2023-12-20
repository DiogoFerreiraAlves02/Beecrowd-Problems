using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int A1 = int.Parse(Console.ReadLine());
            int A2 = int.Parse(Console.ReadLine());
            int A3 = int.Parse(Console.ReadLine());
            
            int[] cases = {A1*0 + A2*2 + A3*4 , A1*2 + A2*0 + A3*2 , A1*4 + A2*2 + A3*0}; 

            Console.WriteLine(cases.Min());
        }  
    }   
} 

