using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] nums;
            int times = int.Parse(Console.ReadLine());

            for(int i = 0; i < times; i++){
                nums = Console.ReadLine().Split(' ');
                if(int.Parse(nums[1]) == 0) {
                    Console.WriteLine("divisao impossivel");
                    continue;
                }
                Console.WriteLine(string.Format("{0:0.0}", double.Parse(nums[0])/double.Parse(nums[1])));

            }
        }
    }   
} 