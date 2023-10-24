using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int month = int.Parse(Console.ReadLine());
            
            var dict = new Dictionary<int,string>(){
                {1,"January"},
                {2,"February"},
                {3,"March"},
                {4,"April"},
                {5,"May"},
                {6,"June"},
                {7,"July"},
                {8,"August"},
                {9,"September"},
                {10,"October"},
                {11,"November"},
                {12,"December"}
            };

            Console.WriteLine(dict[month]);
        }
    }   
} 