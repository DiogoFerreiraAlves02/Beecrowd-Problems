using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input;
            int N;
            float votes;

            while(int.TryParse(Console.ReadLine(),out N)){
                votes = 0;
                input = Console.ReadLine().Split(' ');

                foreach(string num in input){
                    votes += int.Parse(num);
                }

                Console.WriteLine(votes >= N*(2/3.0) ? "impeachment" : "acusacao arquivada");
            }   
        }  
    }   
} 

