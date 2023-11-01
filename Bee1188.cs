using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            
            double[,]M = new double[12,12];
            string T = Console.ReadLine();

            for(int linha = 0; linha < 12; linha++){
                for(int col = 0; col < 12; col++){
                    M[linha,col] = double.Parse(Console.ReadLine());
                }
            }
            int cnt = 0;
            double sum = 0;
            int y = 0;
            for(int i = 11; i >= 7; i--){
                y++;
                for(int j = y; j <i ;j++){
                    sum += M[i,j];
                    cnt++;
                }
            }

            if(T=="S"){
                Console.WriteLine(string.Format("{0:0.0}", sum));
            }
            else{
                Console.WriteLine(string.Format("{0:0.0}", sum/cnt));
            }

        }
    }   
} 