using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = Console.ReadLine().Split();
            int C = int.Parse(input[2]);
            int total = int.Parse(input[0])+int.Parse(input[1]);
            int result = 0;

            while(total>=C){
                int temp = total/C;
                result+=temp;
                total = (total%C)+temp;
            }

            Console.WriteLine(result);
        }
    }   
} 

