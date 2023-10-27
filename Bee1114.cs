using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int guess = 0;
            int pass = 2002;

            do{
                guess = int.Parse(Console.ReadLine());
                if(guess!=pass) Console.WriteLine("Senha Invalida");
            } while(guess != pass);
                
            Console.WriteLine("Acesso Permitido");

        }
    }   
} 