using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string converstionType;
            int[] nums = new int[3];
            string[] input = new string[3];

            for(int i=0; i<n;i++){
                converstionType = Console.ReadLine();
                input = Console.ReadLine().Split(' ');
                for(int j=0;j<3;j++){
                    nums[j] = int.Parse(input[j]);
                }

                if(converstionType == "min") Console.WriteLine($"Caso #{i+1}: {nums.Min()}");
                else if(converstionType == "max") Console.WriteLine($"Caso #{i+1}: {nums.Max()}");
                else if(converstionType == "mean") Console.WriteLine($"Caso #{i+1}: {nums.Sum()/3}");
                else Console.WriteLine($"Caso #{i+1}: {(int) (nums[0]*0.3+nums[1]*0.59+nums[2]*0.11)}");
            }
        }  
    }   
} 

