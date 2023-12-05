using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            string tweet = Console.ReadLine();
            Console.WriteLine(tweet.Length<=140 ? "TWEET" : "MUTE");  
        }   
    }   
} 
