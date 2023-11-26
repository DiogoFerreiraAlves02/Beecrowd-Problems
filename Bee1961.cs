using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] input1 = Console.ReadLine().Split(' ');
            int p = int.Parse(input1[0]);
            int n = int.Parse(input1[1]);
            
            string[] pipesHeight = Console.ReadLine().Split(' ');

            for(int i = 1; i < n; i++){
                if(Math.Abs(int.Parse(pipesHeight[i]) - int.Parse(pipesHeight[i-1])) > p){
                    Console.WriteLine("GAME OVER");
                    return;
                }
            }

            Console.WriteLine("YOU WIN");
        }   
    }   
} 
