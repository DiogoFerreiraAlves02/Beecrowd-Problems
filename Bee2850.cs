using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string word;

            while(!string.IsNullOrEmpty(word = Console.ReadLine())){
                
                switch(word){
                    case "esquerda":
                        Console.WriteLine("ingles");
                        break;
                    case "direita":
                        Console.WriteLine("frances");
                        break;
                    case "nenhuma":
                        Console.WriteLine("portugues");
                        break;
                    case "as duas":
                        Console.WriteLine("caiu");
                        break;
                }
            }
        }
    }   
} 

