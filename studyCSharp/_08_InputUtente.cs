// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _08_InputUtente
    {
        public static void function_08_InputUtente()
        {

            Console.WriteLine("Inserisci il numero 1 : ");
            string numero1 = Console.ReadLine(); /// legge la linea e va accapo 
            Console.WriteLine("Inserisci il numero 2 : ");
            string numero2 = Console.ReadLine(); /// legge la linea e va accapo 

            int num1 = int.Parse(numero1);
            int num2 = int.Parse(numero1);

            int risultato = num1 + num2;
            Console.WriteLine("il risultato e : " + risultato);

            Console.ReadLine(); // messo alla fine evita la chiusura del terminale 
        }
    }
}

