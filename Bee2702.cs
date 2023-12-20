using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            string[] input = new string[3];
            int[] meals = new int[3];
            int[] mealsRequested = new int[3];
            int missedMeals = 0;
            
            input = Console.ReadLine().Split(' ');
            
            for(int i=0;i<3;i++) meals[i] = int.Parse(input[i]);

            input = Console.ReadLine().Split(' ');
            
            for(int i=0;i<3;i++) mealsRequested[i] = int.Parse(input[i]);

            for(int i=0;i<3;i++) if(mealsRequested[i] > meals[i]) missedMeals+= mealsRequested[i] - meals[i];

            Console.WriteLine(missedMeals);

        }  
    }   
} 

