using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int h, m;
            string[] input = new string[2];

            while (true){
                try{
                    input = Console.ReadLine().Split(' ');
                    h = int.Parse(input[0]);
                    m = int.Parse(input[0]);
                }
                catch{ break; }

                string[] values = Console.ReadLine().Split(' ');

                double sum = 0.0, mean, qt = 0.0;

                for(int i=0; i<values.Length; i++){
                    sum += double.Parse(values[i]);
                }

                mean = sum / values.Length;

                for (int i=0; i<values.Length; i++){
                    qt += Math.Pow(double.Parse(values[i]) - mean, 2);
                }

                Console.WriteLine(Math.Sqrt(qt/(values.Length-1)).ToString("F5"));
            }
        }
    }   
} 

