using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){  
            Console.WriteLine("\"Ro'b'er\tto\\/\"");
            string[] emojis1 = {"(._.)","( l: )","( .-. )","( :l )"};
            string[] emojis2 = {"(^_-)","(-_-)","(-_^)"};
            string[] emojis3 = {"(\"_\")","(\'.\')"};

            Console.WriteLine($"{emojis1[0]} {emojis1[1]} {emojis1[2]} {emojis1[3]} {emojis1[0]}\n{emojis2[0]} {emojis2[1]} {emojis2[2]}\n{emojis3[0]} {emojis3[1]}");

        }
    }   
} 

