using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            int result;
            string input;

            for(int i = 1; i <= 3; i++){
                input = "";
                result = 0;
                while(input != "caw caw"){
                    input = Console.ReadLine();
                    if(input == "caw caw") break;
                    input = input.Replace('*','1');
                    input = input.Replace('-','0');
                    result += Convert.ToInt32(input, 2);
                }
                Console.WriteLine(result);
            }
        }
    }   
} 
