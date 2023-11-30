using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            string p1, p2, msg = "";

            for(int i=0;i<n;i++){
                p1 = Console.ReadLine().ToLower();
                p2 = Console.ReadLine().ToLower();

                if(p1 == "ataque"){
                    if(p2 == "pedra") msg = "Jogador 1 venceu";
                    else if(p2 == "ataque") msg = "Aniquilacao mutua";
                    else msg="Jogador 1 venceu";
                }
                else if(p1 == "pedra"){
                    if(p2 == "papel") msg = "Jogador 1 venceu";
                    else if(p2 == "ataque") msg = "Jogador 2 venceu";
                    else msg = "Sem ganhador";
                }
                else if(p1 == "papel"){
                    if(p2 == "ataque") msg = "Jogador 2 venceu";
                    else if(p2 == "pedra") msg = "Jogador 2 venceu";
                    else msg = "Ambos venceram";
                }
                Console.WriteLine(msg);
            }

        }   
    }   
} 
