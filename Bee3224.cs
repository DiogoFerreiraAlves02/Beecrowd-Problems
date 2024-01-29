using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string jon = Console.ReadLine();
            string doctor = Console.ReadLine();

            Console.WriteLine(jon.Length>=doctor.Length ? "go" : "no");
        }
    }   
} 

