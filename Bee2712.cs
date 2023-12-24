using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int n = int.Parse(Console.ReadLine());
            string msg, input;

            for(int i=0; i<n;i++){
                msg="";
                input = Console.ReadLine();
                int num;
                if(!input.Contains("-") || input.ToUpper() != input || input.Length != 8 || input[3] != '-' || !int.TryParse(input.Substring(input.IndexOf("-")), out num) || input.Substring(0, input.IndexOf("-")).Any(char.IsNumber)) {
                    Console.WriteLine("FAILURE");
                    continue;
                }
                
                switch(input.Last()){
                    case '1':
                    case '2':
                        msg = "MONDAY";
                        break;
                    case '3':
                    case '4':
                        msg = "TUESDAY";
                        break;
                    case '5':
                    case '6':
                        msg = "WEDNESDAY";
                        break;
                    case '7':
                    case '8':
                        msg = "THURSDAY";
                        break;
                    case '9':
                    case '0':
                        msg = "FRIDAY";
                        break;
                    default:
                        msg = "FAILURE";
                        break;
                }

                Console.WriteLine(msg);  
            }

        }  
    }   
} 

