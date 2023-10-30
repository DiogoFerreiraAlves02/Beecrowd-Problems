using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int T = int.Parse(Console.ReadLine());
            int n;

            for(int i = 0; i < T; i++){
                n = int.Parse(Console.ReadLine());
                if(n >= 1){
                    ulong[] nums = new ulong[n+1];
                    nums[0] = 0;
                    nums[1] = 1;
                    for(int j = 2; j <= n; j++){
                        nums[j] = nums[j-2] + nums[j-1];
                    }
                    Console.WriteLine($"Fib({n}) = {nums[nums.Length-1]}");
                }
                else{
                    Console.WriteLine($"Fib({n}) = 0");
                }
                
            } 
        }
    }   
} 