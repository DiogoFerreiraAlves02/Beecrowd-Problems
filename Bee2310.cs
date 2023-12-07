using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){   
            string[] inputs = new string[3];
            double totalSaques = 0, pontosSaque = 0, totalBloqueios = 0, pontosBloqueio = 0,totalAtaques = 0, pontosAtaque = 0;
            
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++){
                Console.ReadLine();

                inputs = Console.ReadLine().Split(' ');
                totalSaques += int.Parse(inputs[0]);
                totalBloqueios += int.Parse(inputs[1]);
                totalAtaques += int.Parse(inputs[2]);

                inputs = Console.ReadLine().Split(' ');
                pontosSaque += int.Parse(inputs[0]);
                pontosBloqueio += int.Parse(inputs[1]);
                pontosAtaque += int.Parse(inputs[2]);
            }

            Console.WriteLine($"Pontos de Saque: {string.Format("{0:0.00}",Math.Round(pontosSaque/totalSaques*100,2))} %.\nPontos de Bloqueio: {string.Format("{0:0.00}",Math.Round(pontosBloqueio/totalBloqueios*100,2))} %.\nPontos de Ataque: {string.Format("{0:0.00}",Math.Round(pontosAtaque/totalAtaques*100,2))} %.");
        }   
    }   
} 

