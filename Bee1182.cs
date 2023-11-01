using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            
            double[,]M = new double[12,12];
            int L = int.Parse(Console.ReadLine());
            string T = Console.ReadLine();

            for(int linha = 0; linha < 12; linha++){
                for(int col = 0; col < 12; col++){
                    M[linha,col] = double.Parse(Console.ReadLine());
                }
            }

            double sum = 0;
            for(int i = 0; i < 12 ; i++){
                sum += M[i,L];
            }

            if(T=="S"){
                Console.WriteLine(string.Format("{0:0.0}", sum));
            }
            else{
                Console.WriteLine(string.Format("{0:0.0}", sum/12));
            }

        }
    }   
} 