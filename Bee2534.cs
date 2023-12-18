using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] inputs = new string[2];
            int[] grades;
            int N = 0, Q = 0;
            int pos;

            while(true){
                try{
                    inputs = Console.ReadLine().Split(' ');
                }
                catch{
                    break;
                }
                
                if(string.IsNullOrWhiteSpace(inputs[0])) break;

                N = int.Parse(inputs[0]);
                Q = int.Parse(inputs[1]);
                grades = new int[N];

                for(int i=0;i<N;i++){
                    grades[i] = int.Parse(Console.ReadLine());
                }

                Array.Sort(grades);
                Array.Reverse(grades);

                for(int j=0; j<Q;j++){
                    pos = int.Parse(Console.ReadLine());
                    Console.WriteLine(grades[pos-1]);
                }
            }   
        }  
    }   
} 

