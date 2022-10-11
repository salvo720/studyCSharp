// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

//Generico : fa riferimento ad un particolare tipo di genere (particolare tipo di dato)
// non generico : fa riferimento a tutti i dati insieme 

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _32_Ereditarieta
    {
        public static void function_32_Ereditarieta()
        {
            //Ereditarieta delle classi : una classe puo derivade da un altra classe
            //e derivarne propieta e metodi e successivamente puo andare ad ampliare la classe ed avere cose aggiuntive propie 

            Studente studente1 = new Studente("Luca", "Rossi", 20, "4A");
            Insegnante insegnante1 = new Insegnante("Anna", "Neri", 28, "Storia");

            Console.WriteLine("studente1.Nome : " + studente1.Nome);
            Console.WriteLine("studente1.cognome : " + studente1.cognome);
            Console.WriteLine("studente1.GetEta() : " + studente1.GetEta());
            Console.WriteLine("studente1.classe : " + studente1.classe);

            studente1.Saluta();
            //studente1.Studia();



        }
    }

   
}

