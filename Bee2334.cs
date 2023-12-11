using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){   
            ulong p;
            while(ulong.TryParse(Console.ReadLine(),out p)){
                Console.WriteLine(p-1 == 18446744073709551615 ? 0 : p-1);
            }
            
        }   
    }   
} 

