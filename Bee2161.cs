using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            int n = int.Parse(Console.ReadLine());
            double result = 0.0;

            for(int i=0; i<n; i++){
                result+=6;
                result = 1/result;
            }

            result+=3;

            Console.WriteLine(string.Format("{0:0.0000000000}",result));  
        }   
    }   
} 
