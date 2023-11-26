using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] nums = Console.ReadLine().Split(' ');
            Console.WriteLine(uint.Parse(nums[0])*uint.Parse(nums[1]));
        }   
    }   
} 
