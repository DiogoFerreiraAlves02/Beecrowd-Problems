using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){    
            int X1, Y1, X2, Y2, V, R1, R2;
            double distance;
            string[] inputs = new string[7];

            while(true){
                try{
                    inputs = Console.ReadLine().Split(' ');
                    if(inputs[0] == "") break;
                }
                catch{
                    break;
                }

                X1 = int.Parse(inputs[0]);
                Y1 = int.Parse(inputs[1]);
                X2 = int.Parse(inputs[2]);
                Y2 = int.Parse(inputs[3]);
                V = int.Parse(inputs[4]);
                R1 = int.Parse(inputs[5]);
                R2 = int.Parse(inputs[6]);        

                distance = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)) + V*1.5;

                if(distance > R1+R2) Console.WriteLine("N");
                else Console.WriteLine("Y");
            }
        }   
    }   
} 
