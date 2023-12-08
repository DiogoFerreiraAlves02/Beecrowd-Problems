using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){   
            string[] inputs = Console.ReadLine().Split(' ');

            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);

            string triangleType = "";
            bool rectangle = false;

            if(A >= B+C || B >= A+C || C >= A+B) Console.WriteLine("Invalido");
            else{
                if(A*A == B*B+C*C || B*B == A*A+C*C || C*C == B*B+A*A) rectangle = true;
                
                if(A == B && B == C) triangleType = "Equilatero";
                else if((A == B && B != C) || (A == C && C != B) || (B == C && C != A)) triangleType = "Isoceles";
                else triangleType = "Escaleno";
                
                Console.WriteLine($"Valido-{triangleType}\nRetangulo: {(rectangle ? "S" : "N")}");
            }
        }   
    }   
} 

