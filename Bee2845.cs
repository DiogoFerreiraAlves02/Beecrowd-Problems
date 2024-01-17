using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[n];

            for(int i=0;i<n;i++) nums[i] = int.Parse(input[i]);

            Console.WriteLine(nums.Max()+1);
        }
    }   
} 

