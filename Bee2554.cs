using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int N, D, sum; 
            string date;
            string[] input1 = new string[2];     
            
            while(true){
                try{
                    input1 = Console.ReadLine().Split(' ');
                }
                catch{
                    break;
                }
                if(string.IsNullOrEmpty(input1[0])) break;

                N = int.Parse(input1[0]);
                D = int.Parse(input1[1]);
                date = "";

                for(int i=0; i<D;i++){
                    sum = 0;
                    string[] input2 = Console.ReadLine().Split(' ');
                    for(int j=1;j<=N;j++){
                        sum+=int.Parse(input2[j]);
                    }
                    if(date=="" && sum==N) date = input2[0];
                }

                Console.WriteLine(date=="" ? "Pizza antes de FdI" : date);
            }
        }  
    }   
} 

