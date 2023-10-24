using System;
using System.Security.Cryptography.X509Certificates;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int x = int.Parse(Console.ReadLine());

            int years = x / 365;
            x = x % 365;
            int months = x/30;
            x = x % 30;
            int days = x /1;
            Console.WriteLine($"{years} ano(s)\n{months} mes(es)\n{days} dia(s)");
        }
    }   
} 