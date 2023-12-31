using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string word = "x = 35";
            for(int i=0; i<39;i++) Console.Write("-");
            for(int i=0;i<5;i++){
                Console.Write("\n");
                if(i==0){
                    Console.Write($"|{word}");
                    for(int j=0; j<39-word.Length-1;j++){
                        if(j==39-word.Length-2) Console.Write("|");
                        else Console.Write(" ");
                    }
                }
                else if(i==2){
                    Console.Write("|");
                    for(int j=0; j<15;j++) Console.Write(" ");
                    Console.Write(word);
                    for(int j=0;j<17;j++){
                        Console.Write(j!=16 ? " " : "|");
                    }
                }
                else if(i==4){
                    Console.Write("|");
                    for(int j=0; j<38-word.Length;j++) {
                        if(j==38-word.Length || j==38-word.Length-1){
                            Console.Write($"{word}|");
                        }
                        else Console.Write(" ");
                    }

                }
                else{
                    for(int j=0; j<39;j++){
                        if(j==0 || j==38) Console.Write("|");
                        else Console.Write(" ");
                    }
                }
            }
            Console.Write("\n");
            for(int i=0; i<39;i++) Console.Write("-");
            Console.Write("\n");
        }
    }   
} 

