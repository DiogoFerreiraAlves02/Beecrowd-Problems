using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            for(int i=0; i<39;i++) Console.Write("-");
            Console.WriteLine("\n|  decimal  |  octal  |  Hexadecimal  |");
            for(int i=0; i<39;i++) Console.Write("-");
            for(int i=0; i<16;i++){
                string octal = Convert.ToString(i,8);
                string hexadecimal = i.ToString("X");
                Console.Write("\n|");
                Console.Write(i.ToString().PadLeft(7,' ')+"    |");
                Console.Write(octal.PadLeft(5,' ')+"    |");
                Console.Write(hexadecimal.PadLeft(8,' ')+"       |");
            }
            Console.Write("\n");
            for(int i=0; i<39;i++) Console.Write("-");
            Console.Write("\n");
        }
    }   
} 

