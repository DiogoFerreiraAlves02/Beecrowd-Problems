using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double S = 0;
            for(double i = 3.0, j = 1.0; i <= 39; i+=2.0,j++){
                S += i/Math.Pow(2.0,j);
            }
            Console.WriteLine(string.Format("{0:0.00}", S+1));
        }
    }   
} 