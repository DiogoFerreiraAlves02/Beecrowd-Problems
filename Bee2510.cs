using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string villain;
            for(int i = 0; i<n;i++){
                villain = Console.ReadLine();
                Console.WriteLine(villain.Length<=25 ? "Y" : "N");
            }
        }   
    }   
} 

