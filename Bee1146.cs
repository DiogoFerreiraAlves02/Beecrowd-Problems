using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int x = 0;
            string msg;
            do{
                x = int.Parse(Console.ReadLine()); 
                if(x!=0){
                    msg = "";
                    for(int i = 1; i <= x;i++){
                        msg += i+" ";
                    }
                    Console.WriteLine(msg.TrimEnd());
                }
            } while(x != 0);

        }
    }   
} 