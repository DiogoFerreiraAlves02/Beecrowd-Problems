using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string abc = "abcdefghijklmnopqrstuvwxyz";
            int num = 97;
            for(int i=0;i<26;i++){
                Console.WriteLine($"{num++} e {abc[i]}");
            }
        }
    }   
} 

