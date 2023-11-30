using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double V, D, area = 0, height=0;

            do{
                if(!double.TryParse(Console.ReadLine(),out V)) break;
                if(!double.TryParse(Console.ReadLine(),out D)) break;
                area = 3.14 * Math.Pow((D/2),2); 
                height = V/area;
                Console.WriteLine($"ALTURA = {string.Format("{0:0.00}",height)}\nAREA = {string.Format("{0:0.00}",area)}");
            }while(true);

        }   
    }   
} 
