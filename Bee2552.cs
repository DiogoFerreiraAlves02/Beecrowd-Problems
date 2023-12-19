using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int N, M; 
            string result;
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
                M = int.Parse(input1[1]);

                int[,] arr = new int[N,M];

                for(int i=0; i<N;i++){
                    string[] input2 = Console.ReadLine().Split(' ');
                    for(int j=0;j<M;j++){
                        arr[i,j] = int.Parse(input2[j]);
                    }
                }

                for(int i=0; i<N;i++){
                    result = "";
                    for(int j=0;j<M;j++){
                        if(N!=1){
                            if(arr[i,j] == 1) result+="9";
                            else if(i==0 && j==0){
                                result+=$"{arr[i+1,j]+arr[i,j+1]}";
                            }
                            else if(i==0 && j==M-1){
                                result+=$"{arr[i+1,j]+arr[i,j-1]}";
                            }
                            else if(i==N-1 && j==0){
                                result+=$"{arr[i-1,j]+arr[i,j+1]}";
                            }
                            else if(i==N-1 && j==M-1){
                                result+=$"{arr[i-1,j]+arr[i,j-1]}";
                            }
                            else if(i==0){
                                result+=$"{arr[i,j-1]+arr[i,j+1]+arr[i+1,j]}";
                            }
                            else if(i==N-1){
                                result+=$"{arr[i,j-1]+arr[i,j+1]+arr[i-1,j]}";
                            }
                            else if(j==0){
                                result+=$"{arr[i-1,j]+arr[i,j+1]+arr[i+1,j]}";
                            }
                            else if(j==M-1){
                                result+=$"{arr[i-1,j]+arr[i,j-1]+arr[i+1,j]}";
                            }
                            else{
                                result+=$"{arr[i-1,j]+arr[i+1,j]+arr[i,j-1]+arr[i,j+1]}";
                            }
                        }
                        else{
                            if(arr[i,j] == 1) result+="9";
                            else if(j==0) {
                                result+=$"{arr[i,j+1]}";
                            }
                            else if(j==M-1) {
                                result+=$"{arr[i,j-1]}";
                            }
                            else{
                                result+=$"{arr[i,j+1]+arr[i,j-1]}";
                            }
                        }
                    }
                    Console.WriteLine(result);
                }

            }
        }  
    }   
} 

