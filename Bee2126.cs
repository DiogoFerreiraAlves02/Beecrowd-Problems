using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Beecrowd {
    class Program{
        static void Main(string[] args){     
            string n1;
            string n2;
            int qtd, pos,lastPos,caseNumber=0;
            
            while(true){
                caseNumber++;
                qtd=0;
                pos=0;

                n1 = Console.ReadLine();
                if(n1=="" || n1==null)break;
                n2 = Console.ReadLine();
                if(n2=="" || n1==null)break;

                lastPos = n2.LastIndexOf(n1)+1;

                while(true){
                    pos = n2.IndexOf(n1);
                    if(pos == -1) break;
                    else{
                        qtd++;
                        n2 = n2.Substring(pos+n1.Length, n2.Length-n1.Length-pos);
                    }
                }

                if(qtd!=0)Console.WriteLine($"Caso #{caseNumber}:\nQtd.Subsequencias: {qtd}\nPos: {lastPos}\n");
                else Console.WriteLine($"Caso #{caseNumber}:\nNao existe subsequencia\n");
            }
        }   
    }   
} 
