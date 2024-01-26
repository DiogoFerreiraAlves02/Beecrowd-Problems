using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            int bonecos = 0, arquitetos = 0, musicos = 0, desenhistas = 0;
            for(int i=0;i<n;i++){
                string[] input = Console.ReadLine().Split();
                if(input[1].StartsWith("b")) bonecos+= int.Parse(input[2]);
                else if(input[1].StartsWith("a")) arquitetos+= int.Parse(input[2]);
                else if(input[1].StartsWith("m")) musicos+= int.Parse(input[2]);
                else desenhistas+= int.Parse(input[2]);
            }
            Console.WriteLine(bonecos/8 + arquitetos/4 + musicos/6 + desenhistas/12);
        }
    }   
} 

