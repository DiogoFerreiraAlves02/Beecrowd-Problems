using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string abc = "ABCDE";
    	    int blanks = 8;
            int space = 2;
            for(int i=0; i<5;i++){
                string print = abc[i].ToString().PadLeft(blanks,' ');
                if(abc[i] != 'A'){
                    print += abc[i].ToString().PadLeft(space,' ');
                    space+=2;
                }
                Console.WriteLine(print);
                blanks--;
            }
            space-=4;
            blanks+=2;

            for(int i=3; i>=0;i--){
                string print = abc[i].ToString().PadLeft(blanks,' ');
                if(abc[i] != 'A'){
                    print += abc[i].ToString().PadLeft(space,' ');
                    space-=2;
                }
                Console.WriteLine(print);
                blanks++;
            }

        }
    }   
} 

