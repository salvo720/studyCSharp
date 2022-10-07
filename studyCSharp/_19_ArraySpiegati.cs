// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _19_ArraySpiegati
    {
        public static void function_19_ArraySpiegati()
        {
            // Array : 

            // le parentesi quadre dopo il tipo della variabile , indicano che si tratta di un array 
            // gli array hanno una dimensione gia definita 
            // gli elementi degli array devono essere coerenti con il tipo di dato  , cioe devono essere tutti dello stesso tipo 

            string[] nomi = { "Antonio" , "Marco" , "Luca" };

            foreach (string nome in nomi)
            {
                Console.WriteLine("nome : " + nome);
            }  

            //Array con dimensione definita 

            string[] nomi2 = new string[3];
            nomi2[0] = "Rossi";
            nomi2[1] = "Verdi";
            nomi2[2] = "Neri";

        }
    }
}

