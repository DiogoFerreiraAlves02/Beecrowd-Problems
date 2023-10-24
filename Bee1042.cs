using System;
using System.Globalization;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] stringNum = Console.ReadLine().Split(' ');

            int[] nums = Array.ConvertAll<string, int>(stringNum, int.Parse);
            
            Array.Sort(nums);

            foreach(var num in nums){
                Console.WriteLine(num);
            }
            Console.WriteLine();
            foreach(var num in stringNum){
                Console.WriteLine(num);
            }


        }
    }   
} 