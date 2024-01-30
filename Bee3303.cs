using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string word = Console.ReadLine();
            Console.WriteLine(word.Length>=10 ? "palavrao" : "palavrinha"); 
        }
    }   
} 

