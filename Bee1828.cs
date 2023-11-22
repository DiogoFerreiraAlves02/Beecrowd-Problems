using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            string sheldonAnswer, rajAnswer, msg;
            
            for(int i = 1; i<=n; i++){
                msg = $"Caso #{i}: ";
                string[] answers = Console.ReadLine().Split(' ');
                sheldonAnswer = answers[0].ToLower();
                rajAnswer = answers[1].ToLower();

                if(rajAnswer == sheldonAnswer) msg += "De novo!";
                else if(sheldonAnswer == "tesoura"){
                    if(rajAnswer == "papel" || rajAnswer == "lagarto") msg += "Bazinga!";
                    else msg += "Raj trapaceou!";
                }
                else if(sheldonAnswer == "papel"){
                    if(rajAnswer == "pedra" || rajAnswer == "spock") msg += "Bazinga!";
                    else msg += "Raj trapaceou!";
                }
                else if(sheldonAnswer == "pedra"){
                    if(rajAnswer == "lagarto" || rajAnswer == "tesoura") msg += "Bazinga!";
                    else msg += "Raj trapaceou!";
                }
                else if(sheldonAnswer == "lagarto"){
                    if(rajAnswer == "spock" || rajAnswer == "papel") msg += "Bazinga!";
                    else msg += "Raj trapaceou!";
                }
                else{
                    if(rajAnswer == "tesoura" || rajAnswer == "pedra") msg += "Bazinga!";
                    else msg += "Raj trapaceou!";
                }

                Console.WriteLine(msg);

            }
            
        }
    }   
} 
