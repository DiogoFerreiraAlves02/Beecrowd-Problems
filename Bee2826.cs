using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            List<string> words = new List<string>();

            words.Add(Console.ReadLine());
            words.Add(Console.ReadLine());

            words.Sort();

            foreach (string word in words){
                Console.WriteLine(word);  
            }
        }
    }   
} 

