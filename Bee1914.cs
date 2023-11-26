using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[4];
            string[] numbers = new string[2];
            int sum;
            for(int i=0; i<n;i++){
                input = Console.ReadLine().Split(' ');
                numbers = Console.ReadLine().Split(' ');
                sum = int.Parse(numbers[0]) + int.Parse(numbers[1]);

                if(sum%2 == 0){
                    Console.WriteLine(input[1].ToLower() == "par" ? input[0] : input[2]);
                }
                else{
                    Console.WriteLine(input[1].ToLower() == "impar" ? input[0] : input[2]);
                }
            }
        }   
    }   
} 
