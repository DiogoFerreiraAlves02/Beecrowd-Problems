using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = Console.ReadLine().Split();
            int e = int.Parse(input[0]);
            int d = int.Parse(input[1]);
            string msg = "";

            if(e>d) msg = "Eu odeio a professora!";
            else if(d-e>=3) msg = "Muito bem! Apresenta antes do Natal!";
            else {
                msg = "Parece o trabalho do meu filho!";
                if(e+2 < 24) msg+="\nTCC Apresentado!";
                else msg+="\nFail! Entao eh nataaaaal!";
            }
            
            Console.WriteLine(msg);
        }
    }   
} 

