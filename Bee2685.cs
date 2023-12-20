using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n;
            
            while(int.TryParse(Console.ReadLine(),out n)){
                if(n<90 || n==360) Console.WriteLine("Bom Dia!!");
                else if(n<180) Console.WriteLine("Boa Tarde!!");
                else if(n<270) Console.WriteLine("Boa Noite!!");
                else Console.WriteLine("De Madrugada!!");
            }
        }  
    }   
} 

