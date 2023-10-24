using System;
using System.Globalization;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();
            string animal = "";
            if(word1[0] == 'v'){
                if(word2[0] == 'a'){
                    if(word3[0] == 'c') animal = "aguia";
                    else animal = "pomba";
                }
                else{
                    if(word3[0] == 'o') animal = "homem";
                    else animal = "vaca";
                }
            }
            else{
                if(word2[0] == 'i'){
                    if(word3 == "hematofago") animal = "pulga";
                    else animal = "lagarta";
                }
                else{
                    if(word3[0] == 'h') animal = "sanguessuga";
                    else animal = "minhoca";
                }
            }
            Console.WriteLine(animal);
        }
    }   
} 