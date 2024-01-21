using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            int door, cnt=0;

            for(int i = 0; i < n; i++){
                door = int.Parse(Console.ReadLine());
                if(door!=1) cnt++;
            }

            Console.WriteLine(cnt);
        }
    }   
} 

