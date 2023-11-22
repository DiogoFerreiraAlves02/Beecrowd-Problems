using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n, speed;
            
            while(int.TryParse(Console.ReadLine(),out n)){
                string[] speeds = Console.ReadLine().Split(' ');
                int[] speedsInt = Array.ConvertAll(speeds, x => int.Parse(x));
                speed = speedsInt.Max();
                if(speed >= 20) Console.WriteLine(3);
                else if(speed >= 10) Console.WriteLine(2);
                else Console.WriteLine(1);
            }
            
        }
    }   
} 
