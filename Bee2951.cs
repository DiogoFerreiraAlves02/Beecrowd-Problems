using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input1 = Console.ReadLine().Split();
            int n = int.Parse(input1[0]);
            int friendshipNeed = int.Parse(input1[1]);
            Dictionary<string, int> runesFriendship = new Dictionary<string, int>();
            
            for(int i=0; i<n;i++){
                input1 = Console.ReadLine().Split();
                runesFriendship.Add(input1[0],int.Parse(input1[1]));
            }  
            
            int x = int.Parse(Console.ReadLine());
            string[] input2 = Console.ReadLine().Split();
            int friendship = 0;

            for(int i=0; i<x;i++){
                friendship += runesFriendship[input2[i]];
            }
            
            Console.WriteLine(friendship);
            if(friendship>=friendshipNeed){
                Console.WriteLine("You shall pass!");
            }
            else Console.WriteLine("My precioooous");
        }
    }   
} 

