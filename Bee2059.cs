using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] inputs = Console.ReadLine().Split(' ');
            //p = 1 (EVEN) p = 0 (ODD)
            int p = int.Parse(inputs[0]);
            
            int j1 = int.Parse(inputs[1]);
            int j2 = int.Parse(inputs[2]);

            //r = 1 (CHEATED) r = 0 (DIDNT CHEAT)
            int r = int.Parse(inputs[3]);
            //a = 1 (ACCUSED) a = 0 (DIDNT ACCUSED)
            int a = int.Parse(inputs[4]);
            
            int sum = j1+j2;
            string msg = "";

            if(r == 0 && a == 0){
                if(p == 1){
                    msg = sum % 2 == 0 ? "Jogador 1 ganha!" : "Jogador 2 ganha!";
                }
                else msg = sum % 2 == 0 ? "Jogador 2 ganha!" : "Jogador 1 ganha!";
            }
            else if(r == 0 && a == 1 || r == 1 && a == 0) msg = "Jogador 1 ganha!";
            else if(r == 1 && a == 1) msg = "Jogador 2 ganha!";

            Console.WriteLine(msg);
        }   
    }   
} 
