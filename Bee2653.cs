using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string type;
            List<string> types = new List<string>();
            while(true){
                type = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(type)) break;
                if(!types.Contains(type)) types.Add(type);
            }
            Console.WriteLine(types.Count());
        }  
    }   
} 

