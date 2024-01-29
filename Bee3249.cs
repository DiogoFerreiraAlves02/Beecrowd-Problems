using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string input;
            int result=0;

            for(int i=0;i<n;i++){
                input = Console.ReadLine();
                
                if(!input.Contains("CD")) result++;
            }
            
            Console.WriteLine(result);
        }
    }   
} 

