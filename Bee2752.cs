using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string str = "AMO FAZER EXERCICIO NO URI";

            Console.WriteLine($"<{str}>");
            Console.WriteLine($"<{str.PadLeft(30,' ')}>");
            Console.WriteLine($"<{str.Substring(0,20)}>");
            Console.WriteLine($"<{str}>");
            Console.WriteLine($"<{str.PadRight(30,' ')}>");
            Console.WriteLine($"<{str}>");
            Console.WriteLine($"<{str.Substring(0,20).PadLeft(30,' ')}>");
            Console.WriteLine($"<{str.Substring(0,20).PadRight(30,' ')}>");
        }
    }   
} 

