using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            
            if(n==1){
                Console.WriteLine("1");
                return;
            }
            
            List<int> sequence = new List<int>(){1,1}; 

            for(int i=2;i<n;i++){
                sequence.Add(sequence[i-1]+sequence[i-2]);
            }
            sequence.Reverse();

            Console.WriteLine(String.Join(" ",sequence));
        }
    }   
} 

