using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int m;
            string[] inputs;
            float divider=0, dividend=0;
            while(int.TryParse(Console.ReadLine(),out m)){
                dividend=0;
                divider=0;
                for(int i = 0; i < m; i++){
                    inputs = Console.ReadLine().Split(' ');
                    dividend += int.Parse(inputs[0]) * int.Parse(inputs[1]);
                    divider += int.Parse(inputs[1]);
                }
                Console.WriteLine(string.Format("{0:0.0000}", dividend / (divider*100)));
            }
            
        }  
    }   
} 

