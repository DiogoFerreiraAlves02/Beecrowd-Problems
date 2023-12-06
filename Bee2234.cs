using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){   
            string[] inputs = Console.ReadLine().Split(' ');
            Console.WriteLine(string.Format("{0:0.00}", double.Parse(inputs[0])/double.Parse(inputs[1])));
        }   
    }   
} 
