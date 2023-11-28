using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());

            string[] input = new string[2];
            float bigger = 0;
            string student = "";

            for(int i = 0; i < n; i++){
                input = Console.ReadLine().Split(' ');
                if(float.Parse(input[1]) > bigger){
                    bigger = float.Parse(input[1]);
                    student = input[0]; 
                }
            }

            Console.WriteLine(bigger >= 8 ? student : "Minimum note not reached");

        }   
    }   
} 
