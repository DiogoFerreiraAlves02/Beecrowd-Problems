using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  

            for(int i=0; i<39;i++) Console.Write("-");
            for(int i=0;i<5;i++){
                Console.Write("\n");
                for(int j=0; j<39;j++){
                    if(j==0 || j==38) Console.Write("|");
                    else Console.Write(" ");
                }
            }
            Console.Write("\n");
            for(int i=0; i<39;i++) Console.Write("-");
            Console.Write("\n");
        }
    }   
} 

