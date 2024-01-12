using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int D = int.Parse(Console.ReadLine());
            
            if(D>1400) Console.WriteLine(3);
            else if(D>800) Console.WriteLine(2);
            else Console.WriteLine(1);    
        }
    }   
} 

