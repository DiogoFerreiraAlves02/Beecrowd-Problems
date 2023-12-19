using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = new string[3];
            int N, max, min, guestsAllowed, height;
            
            while(true){
                try{
                    input = Console.ReadLine().Split(' ');
                }catch{
                    break;
                }

                if(!int.TryParse(input[0],out N)) break;

                guestsAllowed = 0;
                min = int.Parse(input[1]);
                max = int.Parse(input[2]);

                for(int i=0; i<N; i++){
                    height = int.Parse(Console.ReadLine());
                    if(height >= min && height <= max) guestsAllowed++;
                }
                Console.WriteLine(guestsAllowed);
            }
        }  
    }   
} 

