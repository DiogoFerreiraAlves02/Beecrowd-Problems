using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double S = 0;
            for(int i = 1; i <= 100; i++){
                S += 1.0/i;
            }
            Console.WriteLine(string.Format("{0:0.00}", S));
        }
    }   
} 