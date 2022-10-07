// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _16_BreakEContinueNeiCicli
    {
        public static void function_16_BreakEContinueNeiCicli()
        {
            Console.WriteLine("i == 1 continue : "); // continue fara andara il ciclo al prossimo elementi senza eseguire il codice del for per qull'eleemnto 
            Console.WriteLine("i == 3 break : "); // break fermera l'esezione del for facendolo uscire 
           
            for (int i = 0; i < 5; i++)
            {
                if (i == 1) continue;
                if (i == 3) break;
                Console.WriteLine("i : " + i );
            }
       
        }
    }
}

