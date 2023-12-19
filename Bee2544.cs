using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n;
            while(int.TryParse(Console.ReadLine(),out n)){
                Console.WriteLine(string.Format("{0:0}",Math.Log(n)/Math.Log(2)));
            }
        }  
    }   
} 

