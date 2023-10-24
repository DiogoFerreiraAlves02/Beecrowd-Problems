using System;
using System.Globalization;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){
            string[] stringNum = Console.ReadLine().Split(' ');

            double A = double.Parse(stringNum[0]);
            double B = double.Parse(stringNum[1]);
            double C = double.Parse(stringNum[2]);

            string triangleType = "";

            if(A >= B+C || B >= A+C || C >= A+B) Console.WriteLine("NAO FORMA TRIANGULO");
            else{
                if(A*A == B*B+C*C || B*B == A*A+C*C || C*C == B*B+A*A) triangleType += "TRIANGULO RETANGULO\n";
                else if(A*A > B*B+C*C || B*B > A*A+C*C || C*C > A*A+B*B) triangleType += "TRIANGULO OBTUSANGULO\n";
                else if(A*A < B*B+C*C || B*B < A*A+C*C || C*C < B*B+A*A) triangleType += "TRIANGULO ACUTANGULO\n";
                if(A == B && B == C) triangleType += "TRIANGULO EQUILATERO\n";
                if((A == B && B != C) || (A == C && C != B) || (B == C && C != A)) triangleType += "TRIANGULO ISOSCELES\n";
                
                Console.Write(triangleType);
            }       

        }
    }   
} 