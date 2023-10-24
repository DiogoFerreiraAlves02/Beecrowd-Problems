using System;
using System.Globalization;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] stringNum = Console.ReadLine().Split(' ');

            int A = int.Parse(stringNum[0]);
            int B = int.Parse(stringNum[1]);

            if(A == B) Console.WriteLine($"O JOGO DUROU 24 HORA(S)");    
            else if(A < B) Console.WriteLine($"O JOGO DUROU {B-A} HORA(S)");
            else Console.WriteLine($"O JOGO DUROU {24-A+B} HORA(S)");
        }
    }   
} 