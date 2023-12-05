using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            int n = int.Parse(Console.ReadLine());
            string[] speeds = Console.ReadLine().Split(' ');
            int index = 0;

            for(int i=0; i<n-1; i++){
                if(int.Parse(speeds[i]) > int.Parse(speeds[i+1])){
                    index = i+2;
                    break;
                }
            }
            Console.WriteLine(index);
        }   
    }   
} 
