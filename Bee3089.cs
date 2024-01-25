using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n;
            while((n = int.Parse(Console.ReadLine())) != 0){
                string[] input = Console.ReadLine().Split();
                int expensive = 0, cheapest = 0;

                for(int i=0;i<n;i++){
                    int price = int.Parse(input[i])+int.Parse(input[input.Length-i-1]);
                    if(price > expensive){
                        expensive = price;
                    }
                    if(cheapest == 0 || price < cheapest){
                        cheapest = price;
                    }
                }

                Console.WriteLine($"{expensive} {cheapest}");
            }
        }
    }   
} 

