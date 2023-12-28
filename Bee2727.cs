using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n;
            string[] input;
            string abc = "abcdefghijklmnopqrstuvwxyz";
            while(int.TryParse(Console.ReadLine(),out n)){
                for(int i=0; i<n;i++){
                    input = Console.ReadLine().Split(' ');
                    int pos = input[0].Length + 3*(input.Length-1);
                    Console.WriteLine(abc[pos-1]);
                }
            }        
        }
    }   
} 

