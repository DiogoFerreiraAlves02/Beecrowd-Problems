using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            var menu = new Dictionary<int, double>(){
                {1001, 1.50},
                {1002, 2.50},
                {1003, 3.50},
                {1004, 4.50},
                {1005, 5.50}
            };

            int n = int.Parse(Console.ReadLine());
            double total = 0;
            for(int i=0; i<n; i++){
               string[] input = Console.ReadLine().Split(' ');  
               total += menu[int.Parse(input[0])] * int.Parse(input[1]);
            }
            Console.WriteLine(string.Format("{0:0.00}",total));
        }   
    }   
} 
