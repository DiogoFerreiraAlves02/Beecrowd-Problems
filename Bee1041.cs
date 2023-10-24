using System;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] scores = Console.ReadLine().Split(' ');
            double X = double.Parse(scores[0]);
            double Y = double.Parse(scores[1]);
            string msg = "";
            if(X + Y == 0) msg = "Origem";
            else if(X == 0) msg = "Eixo Y";
            else if(Y == 0) msg = "Eixo X";
            else if(X > 0 && Y > 0) msg = "Q1";
            else if(X > 0 && Y < 0) msg = "Q4";
            else if(X < 0 && Y > 0) msg = "Q2";
            else if(X < 0 && Y < 0) msg = "Q3";
            
            Console.WriteLine(msg);
        }
    }   
} 