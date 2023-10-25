using System;
using System.Globalization;
using System.Collections.Generic;
namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int num = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= num; i++){
                if(i % 2 != 0) Console.WriteLine(i);
            }
            
        }
    }   
} 