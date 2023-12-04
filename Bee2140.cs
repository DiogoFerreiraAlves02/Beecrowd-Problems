using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            int n, m, bills,change;
            string[] input = new string[2];

            while(true){
                bills=0;
                input = Console.ReadLine().Split(' ');
                n = int.Parse(input[0]);
                m = int.Parse(input[1]);
                if(n == 0 && m == 0) break;
                change = m-n;

                if(change>=100) {
                    change = change - 100;
                    bills++;
                }
                if(change>=50 && bills<2) {
                    change = change - 50;
                    bills++;
                }
                if(change>=20 && bills<2){
                    change = change - 20;
                    bills++;
                }
                if(change>=10 && bills<2) {
                    change = change - 10;
                    bills++;
                }
                if(change>=5 && bills<2){
                    change = change - 5;
                    bills++;
                }
                if(change>=2 && bills<2){
                    change = change - 2;
                    bills++;
                }

                Console.WriteLine(change == 0 && bills == 2 ? "possible" : "impossible");
            }
        }   
    }   
} 
