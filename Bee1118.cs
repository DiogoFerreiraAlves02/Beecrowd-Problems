using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double n = 0.0;
            double sum = 0;
            int cnt = 0;
            bool newCalc = true;

            while(newCalc){
                
                if(cnt != 2){
                    n = double.Parse(Console.ReadLine());
                    if(n<0 || n>10) Console.WriteLine("nota invalida");
                    else{
                        cnt++;
                        sum+=n;
                    }
                }
                else{
                    Console.WriteLine("media = " + string.Format("{0:0.00}", sum/2));
                    do{
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        n = double.Parse(Console.ReadLine());
                    }while(n<1 || n>2);
                    if(n==2) newCalc = false;
                    else{
                        sum = 0;
                        cnt = 0;
                    }
                }
                
            }
            
        }
    }   
} 