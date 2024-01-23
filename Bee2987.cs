using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string l = Console.ReadLine();
            Console.WriteLine(alphabet.IndexOf(l)+1);
        }
    }   
} 

