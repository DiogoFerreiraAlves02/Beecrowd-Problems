using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            int N = int.Parse(Console.ReadLine()); 
            string[] input = new string[2];
            string[] songs = {"PROXYCITY","P.Y.N.G.","DNSUEY!","SERVERS","HOST!","CRIPTONIZE","OFFLINE DAY","SALT","ANSWER!","RAR?","WIFI ANTENNAS"};
            for(int i=0; i<N; i++){
                input = Console.ReadLine().Split(' ');
                Console.WriteLine(songs[int.Parse(input[0])+int.Parse(input[1])]);
            } 
            
        }  
    }   
} 

