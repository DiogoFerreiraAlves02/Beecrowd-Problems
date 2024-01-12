using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string[] sequence = Console.ReadLine().Split();
            int result = 1; 

            for(int i=2;i<n;i++){
                if(int.Parse(sequence[i])-int.Parse(sequence[i-1]) != int.Parse(sequence[i-1])-int.Parse(sequence[i-2])) result++;
            }  
            Console.WriteLine(result);
        }
    }   
} 

