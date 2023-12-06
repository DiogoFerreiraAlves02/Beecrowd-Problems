using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            string n = Console.ReadLine();
            int ones = 0;
            foreach(var num in n){
                if(num=='1') ones++;
            }

            Console.WriteLine(ones%2==0 ? $"{n}0" : $"{n}1");
        }   
    }   
} 
