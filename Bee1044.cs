using System;
using System.Globalization;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] stringNum = Console.ReadLine().Split(' ');

            int A = int.Parse(stringNum[0]);
            int B = int.Parse(stringNum[1]);

            Console.WriteLine((A % B == 0 || B % A == 0) ? "Sao Multiplos" : "Nao sao Multiplos");

        }
    }   
} 