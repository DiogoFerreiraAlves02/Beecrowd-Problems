using System;
using System.Globalization;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] stringNum = Console.ReadLine().Split(' ');

            int A = int.Parse(stringNum[0]);
            int B = int.Parse(stringNum[1]);
            int C = int.Parse(stringNum[2]);
            int D = int.Parse(stringNum[3]);

            int dif = ((C*60)+D) - ((A*60)+B);
            if(dif <= 0) dif += 24*60;
            Console.WriteLine($"O JOGO DUROU {dif/60} HORA(S) E {dif%60} MINUTO(S)");
        }
    }   
} 