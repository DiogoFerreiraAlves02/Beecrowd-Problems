using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int n = 0;
            do{
                do{
                    n = int.Parse(Console.ReadLine());
                } while(n<1 || n>4);
                if(n == 1) alcool++;
                else if(n == 2) gasolina++;
                else if(n == 3) diesel++;
            } while(n != 4);         

            Console.WriteLine($"MUITO OBRIGADO\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
        }
    }   
} 