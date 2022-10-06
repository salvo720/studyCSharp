// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _14_CicloWhileEDoWhile
    {
        public static void function_14_CicloWhileEDoWhile()
        {
            //loop o cicli 
            //while , dowhile , if annidatai 

            int i = 0;
            int j1 = 0;
            int j = 0;

            while (i<4)
            {
                if (i == 3)
                {
                    Console.WriteLine("siamo i 3 porcellini ");
                }
                Console.WriteLine("i : " + i);
                i++;
            }

            while (j1 < 0) ;
            {
                Console.WriteLine("j " + j);
                j1++;
            } 

            do
            {
                Console.WriteLine("j "+ j);
                j++;
            } while (j<0);

            // La differenza tra while e do while (guarda i due cicli con j e j1) :
            // 1) il while verifica la condizione prima di eseguire il codice del loop
            // 2) il dowhile esegue prima il codice  del loop e dopo verifica la condizione , 
            // 
        }
    }
}

