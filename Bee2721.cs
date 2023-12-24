using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] reindeers = {"Dasher","Dancer","Prancer","Vixen","Comet","Cupid","Donner","Blitzen","Rudolph"};

            string[] input = Console.ReadLine().Split(' ');
            int sum=0;

            for(int i=0; i<input.Length;i++){
                sum+= int.Parse(input[i]);
            }

            Console.WriteLine(reindeers[(sum-1 ) % 9]);
        }
    }   
} 

