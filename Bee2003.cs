using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int hour;
            string time = "";
            int minute = 0;
            int atraso = 0;
            while(true) {
                time = Console.ReadLine();

                if(string.IsNullOrEmpty(time)) break;

                hour = int.Parse(time.Substring(0,1));
                minute = int.Parse(time.Substring(2,2));

                if(hour >= 5 && hour <= 6) atraso = 0;
                else if(hour==7) atraso = minute;
                else if(hour==8) atraso = minute+60;
                else if(hour==9) atraso = minute+120;

                Console.WriteLine("Atraso maximo: " + atraso);
            } 
        }   
    }   
} 
