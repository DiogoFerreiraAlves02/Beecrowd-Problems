using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            
            int times = int.Parse(Console.ReadLine());
            string[] nums = new string[2];
            int[] results = new int[times];
            int sum = 0;
            int x, y;

            for(int i = 0; i < times; i++){
                nums = Console.ReadLine().Split(' ');
                x = int.Parse(nums[0]);
                y = int.Parse(nums[1]);
                sum = 0;
                if(x > y){
                    for(int j = y+1; j < x; j++){
                        if(j%2 != 0) sum+=j;
                    }
                    results[i] = sum;
                    continue;
                }
                if(x < y){
                    for(int cnt = x+1; cnt < y; cnt++){
                        if(cnt%2 != 0) sum+=cnt;
                    }
                    results[i] = sum;
                    continue;
                }
                results[i] = sum;
            }
            
            foreach(int result in results) Console.WriteLine(result);
        }
    }   
} 