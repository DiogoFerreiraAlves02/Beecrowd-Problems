using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){

            int n = 0;
            int inter = 0;
            int gremio = 0;
            int empates = 0;
            string[] inputs;

            while(true){
                inputs = Console.ReadLine().Split(' ');
                if(int.Parse(inputs[0]) > int.Parse(inputs[1])){
                    inter++;
                }
                else if(int.Parse(inputs[0]) < int.Parse(inputs[1])){
                    gremio++;
                }
                else empates++;
                do{
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    n = int.Parse(Console.ReadLine());
                }while(n<1 || n>2);
                if(n==2) break;
            }

            Console.WriteLine($"{inter+gremio+empates} grenais\nInter:{inter}\nGremio:{gremio}\nEmpates:{empates}\n{(inter > gremio ? "Inter venceu mais" : (inter == gremio ? "Não houve vencedor" : "Gremio venceu mais"))}");           
            
        }
    }   
} 