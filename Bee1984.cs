using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string input = Console.ReadLine();
            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);
            Console.WriteLine(new string(charArr));
        }   
    }   
} 
