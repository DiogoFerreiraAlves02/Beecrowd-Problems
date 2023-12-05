using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            int n = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int samePattern=1;

            if(n==1){}
            else if(n==2){
                if(int.Parse(inputs[0]) == int.Parse(inputs[1])) samePattern=0;
            }
            else if(int.Parse(inputs[0]) > int.Parse(inputs[1])){
                for(int i=0; i<n-1; i++){
                    if(i%2==0 && (int.Parse(inputs[i]) < int.Parse(inputs[i+1]) || int.Parse(inputs[i]) == int.Parse(inputs[i+1]))){
                        samePattern=0;
                        break;
                    }
                    else if(i%2!=0 && (int.Parse(inputs[i]) > int.Parse(inputs[i+1]) || int.Parse(inputs[i]) == int.Parse(inputs[i+1]))){
                        samePattern=0;
                        break;
                    }
                }
            }
            else if(int.Parse(inputs[0]) < int.Parse(inputs[1])){
                for(int i=0; i<n-1; i++){
                    if(i%2==0 && (int.Parse(inputs[i]) > int.Parse(inputs[i+1]) || int.Parse(inputs[i]) == int.Parse(inputs[i+1]))){
                        samePattern=0;
                        break;
                    }
                    else if(i%2!=0 && (int.Parse(inputs[i]) < int.Parse(inputs[i+1]) || int.Parse(inputs[i]) == int.Parse(inputs[i+1]))){
                        samePattern=0;
                        break;
                    }
                }
            }
            Console.WriteLine(samePattern);  
        }   
    }   
} 
