using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[2];
            int maria,joao;

            for(int i=0;i<n;i++){
                maria=0;
                joao=0;
                for(int j=0;j<3;j++){
                    input = Console.ReadLine().Split(' ');
                    joao+=int.Parse(input[0])*int.Parse(input[1]);
                }
                for(int j=0;j<3;j++){
                    input = Console.ReadLine().Split(' ');
                    maria+=int.Parse(input[0])*int.Parse(input[1]);
                }
                Console.WriteLine(maria>joao?"MARIA":"JOAO");
            }
        }
    }   
} 

