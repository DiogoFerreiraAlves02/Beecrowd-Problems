using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n;
            while(int.TryParse(Console.ReadLine(), out n)){
                Console.WriteLine(Math.Ceiling(n/100.0));
            }   
        }
    }   
} 

