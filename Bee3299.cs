using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string n = Console.ReadLine();

            Console.WriteLine(n.Contains("13") ? $"{n} es de Mala Suerte" : $"{n} NO es de Mala Suerte");            
        }
    }   
} 

