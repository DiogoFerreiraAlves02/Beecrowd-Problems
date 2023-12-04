using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            int hour,min,door;
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[3];

            for(int i=0;i<n;i++){
                input = Console.ReadLine().Split(' ');
                hour = int.Parse(input[0]);
                min = int.Parse(input[1]);
                door = int.Parse(input[2]);
                Console.WriteLine($"{string.Format("{0:00}",hour)}:{string.Format("{0:00}",min)} - A porta {(door==1? "abriu" : "fechou")}!");
            }            
        }   
    }   
} 
