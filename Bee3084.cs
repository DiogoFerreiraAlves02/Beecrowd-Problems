using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = new string[2];
            int hours, minutes;
            while(true){
                try{
                    input = Console.ReadLine().Split();
                    if(input[0] == "") break;
                }
                catch{break;}
                hours = 6*int.Parse(input[0])/180;
                minutes = 30*int.Parse(input[1])/180;
                Console.WriteLine($"{string.Format("{0:00}",hours)}:{string.Format("{0:00}",minutes)}");
            }   
        }
    }   
} 

