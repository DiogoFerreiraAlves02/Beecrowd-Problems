using System;
using System.Globalization;
using System.Collections.Generic;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string DDD = Console.ReadLine();
            var cities = new Dictionary<string, string>(){
                {"61", "Brasilia"},
                {"71", "Salvador"},
                {"11", "Sao Paulo"},
                {"21", "Rio de Janeiro"},
                {"32", "Juiz de Fora"},
                {"19", "Campinas"},
                {"27", "Vitoria"},
                {"31", "Belo Horizonte"}
            };
            foreach(var kvp in cities){
                if(kvp.Key == DDD) {
                    Console.WriteLine(kvp.Value);
                    return;
                }               
            }
            Console.WriteLine("DDD nao cadastrado");
    
        }
    }   
} 