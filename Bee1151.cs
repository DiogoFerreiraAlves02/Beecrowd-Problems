using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            nums[0] = 0;
            nums[1] = 1;
            string msg = "";
            for(int i = 2; i < n; i++){
                nums[i] = nums[i-2] + nums[i-1];
            }

            foreach(var num in nums){
                msg += num + " ";
            }
            Console.WriteLine(msg.TrimEnd());
        }
    }   
} 