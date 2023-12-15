using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string letters, msg;
            char[] arrLetters;
            string[] input;
            int n;
            while(true){
                letters = Console.ReadLine();
                if(letters == null || letters == "") break;
                msg = "";
                arrLetters = letters.ToCharArray();
                n = int.Parse(Console.ReadLine());
                input = Console.ReadLine().Split(' ');

                for(int i=0; i<n; i++){
                    msg += arrLetters[int.Parse(input[i])-1];
                }

                Console.WriteLine(msg);
            }
            
        }  
    }   
} 

