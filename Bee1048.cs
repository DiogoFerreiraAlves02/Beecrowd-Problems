using System;
using System.Globalization;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double salary = double.Parse(Console.ReadLine());

            double readjustmentRate = 0;

            if(salary >= 0 && salary <= 400) readjustmentRate = .15;
            else if(salary > 400 && salary <= 800) readjustmentRate = .12;
            else if(salary > 800 && salary <= 1200) readjustmentRate = .10;
            else if(salary > 1200 && salary <= 2000) readjustmentRate = .07;
            else readjustmentRate = .04;

            Console.WriteLine("Novo salario: " + string.Format("{0:0.00}", salary+(salary*readjustmentRate)));
            Console.WriteLine("Reajuste ganho: " + string.Format("{0:0.00}", salary*readjustmentRate));
            Console.WriteLine("Em percentual: " + readjustmentRate*100 + " %");

        }
    }   
} 