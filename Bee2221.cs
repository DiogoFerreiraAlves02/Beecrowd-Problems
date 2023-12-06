using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){    
            int t = int.Parse(Console.ReadLine());
            int b;
            double total1 = 0, total2 = 0;
            string[] inputs = new string[3];

            for(int i=0; i<t; i++){
                b = int.Parse(Console.ReadLine());

                inputs = Console.ReadLine().Split(' ');

                total1 = (int.Parse(inputs[0]) + int.Parse(inputs[1])) / 2;
                if(int.Parse(inputs[2]) % 2 == 0) total1 += b;

                inputs = Console.ReadLine().Split(' ');

                total2 = (int.Parse(inputs[0]) + int.Parse(inputs[1])) / 2;
                if(int.Parse(inputs[2]) % 2 == 0) total2 += b;

                Console.WriteLine(total1 > total2 ? "Dabriel" : total2 == total1 ? "Empate" : "Guarte");
            }
        }   
    }   
} 
