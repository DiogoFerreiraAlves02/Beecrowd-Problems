using System;
using System.Globalization;
using System.Collections.Generic;
namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int num = 0;
            int par = 0;
            int impar = 0;
            int pos = 0;
            int neg = 0;

            for(int i = 0; i < 5; i++){
                num = int.Parse(Console.ReadLine());
                if(num % 2 == 0) par++;
                else impar++;
                if(num > 0) pos++;
                else if(num < 0) neg++;
            }
            Console.WriteLine($"{par} valor(es) par(es)\n{impar} valor(es) impar(es)\n{pos} valor(es) positivo(s)\n{neg} valor(es) negativo(s)");
        }
    }   
} 