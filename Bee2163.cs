using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            string[] inputs = Console.ReadLine().Split(' ');
            int rows = int.Parse(inputs[0]);
            int columns = int.Parse(inputs[1]);
            int[,] terrain = new int[rows,columns];
            
            for(int i=0; i<rows; i++){
                inputs = Console.ReadLine().Split(' ');
                for(int j=0; j<columns; j++){
                    terrain[i,j] = int.Parse(inputs[j]);
                }
            }

            for(int i=0; i<rows; i++){
                for(int j=0; j<columns; j++){
                    if(terrain[i,j] == 42 && i!=0 && j!=0 && i!=rows-1 && j!=columns-1){
                        if(terrain[i-1,j-1] == 7 && terrain[i,j-1] == 7 && terrain[i+1,j-1] == 7 && terrain[i+1,j] == 7 && terrain[i+1,j+1] == 7 && terrain[i,j+1] == 7 && terrain[i-1,j+1] == 7 && terrain[i-1,j] == 7){
                            Console.WriteLine($"{i+1} {j+1}");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("0 0");
        }   
    }   
} 
