using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] coordinates;
            int x = 0;
            int y = 0;
            string msg = "";

            while(true){
                coordinates = Console.ReadLine().Split(' ');
                x = int.Parse(coordinates[0]);
                y = int.Parse(coordinates[1]);
                if(x == 0 || y == 0) break;
                if(x > 0 && y > 0) msg = "primeiro";
                else if(x > 0 && y < 0) msg = "quarto";
                else if(x < 0 && y > 0) msg = "segundo";
                else if(x < 0 && y < 0) msg = "terceiro";
                Console.WriteLine(msg);
            }
        }
    }   
} 