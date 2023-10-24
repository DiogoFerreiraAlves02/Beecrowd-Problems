using System;
using System.Globalization;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            double salary = double.Parse(Console.ReadLine());

            if(salary >= 0 && salary <= 2000){
                Console.WriteLine("Isento");
            }
            else if(salary > 2000 && salary <= 3000) {
                Console.WriteLine("R$ " + string.Format("{0:0.00}", (salary-2000)*.08));
            }
            else if(salary > 3000 && salary <= 4500) {
                Console.WriteLine("R$ " + string.Format("{0:0.00}", (salary-3000)*.18 + 1000*.08));
            }
            else{
                Console.WriteLine("R$ " + string.Format("{0:0.00}", (salary-4500)*.28 + 1500*.18 + 1000*.08));
            }
        }
    }   
} 