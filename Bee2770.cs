using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] inputs;
            int X,Y,Z;

            while(true){
                try{
                    inputs = Console.ReadLine().Split(' ');
                    X = int.Parse(inputs[0]);
                    Y = int.Parse(inputs[1]);
                    Z = int.Parse(inputs[2]);
                }
                catch{
                    break;
                }
                for(int i=0;i<Z;i++){
                    try{
                        inputs = Console.ReadLine().Split(' ');
                        Console.WriteLine( (int.Parse(inputs[0]) <= X && int.Parse(inputs[1]) <= Y) || (int.Parse(inputs[0]) <= Y && int.Parse(inputs[1]) <= X) ? "Sim" : "Nao");
                    }
                    catch{
                        break;
                    }
                    
                }
            
            }
        }
    }   
} 

