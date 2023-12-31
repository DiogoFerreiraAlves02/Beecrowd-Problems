using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] words = {"Roberto","5786","UNIFEI"};
            int wordsCount=0;
            for(int i=0; i<39;i++) Console.Write("-");
            for(int i=0;i<5;i++){
                Console.Write("\n");
                if(i%2==0){
                    int lastIndex = 39-words[wordsCount].Length;
                    for(int j=0; j<=lastIndex;j++){
                        if(j==0 || j==lastIndex) Console.Write("|");
                        else if(j == 9) Console.Write(words[wordsCount]);
                        else Console.Write(" ");
                    }
                    wordsCount++;
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

