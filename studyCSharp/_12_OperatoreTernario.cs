// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _12_OperatoreTernario
    {
        public static void function_12_OperatoreTernario()
        {
            //operatore ternario : condizione ? caso1 : caso2 ; 
            //operatore ternario annidato : condizione ? caso1 : ( condizione ? caso1 : caso2 ) ; 

            string nome = "Marco";
            string nome2;
            int numero = 55;
            string typeNumero;
            if (5 > 6) nome = "Luca"; Console.WriteLine("nome : " + nome); // in questo caso verra eseguito all'interno dell'if solo la prima istruzione quindi nome = "Luca" ,
                                                               // Console.WriteLine(nome); verra eseguito perche conta come fuori dall'if  

            nome2 = 5 > 6 ? "Luca" : "Marco";
            Console.WriteLine("nome2 : " + nome2);

            typeNumero = numero % 2 != 0 ? " dispari" : (numero > 10 ? " pari ed è : > 10 " : " pari ed è : < 10")  ; // l'if ternario annidato va usato sulla seconda posizione 
            Console.WriteLine("typeNumero : " + typeNumero);

        }
    }
}

