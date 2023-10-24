using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] values = Console.ReadLine().Split(' ');
            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);
            int C = int.Parse(values[2]);
            int D = int.Parse(values[3]);

            bool firstCondition = B > C && D > A;
            bool secondCondition = C+D > A+B;
            bool thirdCondition = C > 0 && D > 0;
            bool fourthCondition = A % 2 == 0;

            Console.WriteLine(firstCondition && secondCondition && thirdCondition && fourthCondition ? "Valores aceitos" : "Valores nao aceitos");
        }
    }   
} 