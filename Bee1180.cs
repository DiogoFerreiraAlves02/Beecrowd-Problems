using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split(' ');
            int menor = int.Parse(nums[0]);
            int pos = 0;

            for(int i = 0; i < n; i++){
                if(int.Parse(nums[i]) < menor){
                    menor = int.Parse(nums[i]);
                    pos = i;
                }
            }

            Console.WriteLine("Menor valor: " + menor + "\nPosicao: " + pos);
        }
    }   
} 