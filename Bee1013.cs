using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] Maior = Console.ReadLine().Split(' ');
            int A = int.Parse(Maior[0]);
            int B = int.Parse(Maior[1]);
            int C = int.Parse(Maior[2]);
            
            int MaiorAB = (A+B+Math.Abs(A-B))/2;
            int MaiorABC = (MaiorAB+C+Math.Abs(MaiorAB-C))/2;
            Console.WriteLine($"{MaiorABC} eh o maior");            
        }
    }   
} 