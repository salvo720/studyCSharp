// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _17_CosaSonoIMetodiParametriEReturn
    {
        public static void function_17_CosaSonoIMetodiParametriEReturn()
        {
            Saluta("Giornata 0 : "); // caso orario default 
            Saluta("Marco",2 ); 
            Saluta(orario:1 , nome:"Marco"); //PARAMETRI NOMINATI , nota che nominado i parametri possiamo anche non rispettare l'ordine dei parametri 

            int risultato = FaiSomma(10 , 20);
            Console.WriteLine("il riusltato e : " + risultato);
        }

        public static void Saluta( string nome , int orario = 0) //assegnado a orario = 0 nella dichiarazione della funzione sara il parametro di default se non viene passato 
        {
            switch (orario)
            {
                case 0:
                    Console.WriteLine($"Ciao { nome} Buongiorno ");
                    break;
                case 1:
                    Console.WriteLine($"Ciao {nome} Buonpomeriggio ");
                    break;
                case 2:
                    Console.WriteLine($"Ciao {nome} Buona serata ");
                    break;
                default:
                    Console.WriteLine("Orario non compreso tra i casi ");
                    break;
            }
    
        }

        public static int FaiSomma(int num1 = 0, int num2 = 0)
        {
            return num1 + num2;
        }
    }
}

