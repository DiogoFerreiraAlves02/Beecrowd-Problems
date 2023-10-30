using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            List<int> idades = new List<int>();
            int idade = 0;
            do{
                idade = int.Parse(Console.ReadLine());
                if(idade>= 0) idades.Add(idade);
            } while(idade>=0);

            double avg = idades.Average();

            Console.WriteLine(string.Format("{0:0.00}",avg));
        }
    }   
} 