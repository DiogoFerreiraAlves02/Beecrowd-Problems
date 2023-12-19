using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string dodo, leo, pepper;
            string[] input = new string[3];
            string msg;

            while(true){
                try{
                    input = Console.ReadLine().Split(' ');
                }
                catch{
                    break;
                }
                if(string.IsNullOrWhiteSpace(input[0])) break;

                dodo = input[0];
                leo = input[1];
                pepper = input[2];

                if(dodo == "papel" && leo == "papel" && pepper == "tesoura") msg = "Urano perdeu algo muito precioso...";
                else if(dodo == "papel" && leo == "pedra" && pepper == "pedra") msg = "Os atributos dos monstros vao ser inteligencia, sabedoria...";
                else if(dodo == "papel" && leo == "tesoura" && pepper == "papel") msg = "Iron Maiden's gonna get you, no matter how far!";
                else if(dodo == "pedra" && leo == "papel" && pepper == "pedra") msg = "Iron Maiden's gonna get you, no matter how far!";
                else if(dodo == "pedra" && leo == "pedra" && pepper == "papel") msg = "Urano perdeu algo muito precioso...";
                else if(dodo == "pedra" && leo == "tesoura" && pepper == "tesoura") msg = "Os atributos dos monstros vao ser inteligencia, sabedoria...";
                else if(dodo == "tesoura" && leo == "papel" && pepper == "papel") msg = "Os atributos dos monstros vao ser inteligencia, sabedoria...";
                else if(dodo == "tesoura" && leo == "pedra" && pepper == "tesoura") msg = "Iron Maiden's gonna get you, no matter how far!";
                else if(dodo == "tesoura" && leo == "tesoura" && pepper == "pedra") msg = "Urano perdeu algo muito precioso...";
                else msg = "Putz vei, o Leo ta demorando muito pra jogar...";
                
                Console.WriteLine(msg);
            }
        }  
    }   
} 

