using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            int result = 1;

            for(int i = 0; i < n; i++){
                result = result * (n-i);
            }

            Console.WriteLine(result);
        }
    }   
} 