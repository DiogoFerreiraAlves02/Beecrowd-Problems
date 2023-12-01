using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] inputs = Console.ReadLine().Split(' ');
            int departure = int.Parse(inputs[0]);
            int travelTime = int.Parse(inputs[1]);
            int timeZone = int.Parse(inputs[2]);
            
            int sum = departure+travelTime+timeZone;
            
            if(sum>=24) sum -=24; 
            if(sum<0) sum+=24;

            Console.WriteLine(sum);
        }   
    }   
} 
