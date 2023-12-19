using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] inputs = new string[2];
            int N, I, cnt=0;
            
            while(true){
                
                try{
                    inputs = Console.ReadLine().Split(' ');
                }catch{
                    break;
                }
                
                if(!int.TryParse(inputs[0],out N)) break;

                cnt = 0;
                I = int.Parse(inputs[1]);

                for(int k=0; k<N; k++){
                    inputs = Console.ReadLine().Split(' ');
                    if(int.Parse(inputs[0]) == I && int.Parse(inputs[1]) == 0) cnt++;
                }
                Console.WriteLine(cnt);
            }
        }  
    }   
} 

