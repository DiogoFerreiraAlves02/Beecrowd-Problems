using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            float n;
            float seconds,minute,hour;
            while(float.TryParse(Console.ReadLine(),out n)){
                
                if(n<90 || n==360) Console.WriteLine("Bom Dia!!");
                else if(n<180) Console.WriteLine("Boa Tarde!!");
                else if(n<270) Console.WriteLine("Boa Noite!!");
                else Console.WriteLine("De Madrugada!!");

                seconds = n*240+21600;
                minute = (int) (seconds/60);
                seconds = (int) (seconds%60);
                hour = (int) (minute/60) % 24;
                minute = (int) (minute%60);

                Console.WriteLine($"{string.Format("{0:00}",hour)}:{string.Format("{0:00}",minute)}:{string.Format("{0:00}",seconds)}");
            }
        }  
    }   
} 

