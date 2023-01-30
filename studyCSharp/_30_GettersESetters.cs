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
    internal class _30_GettersESetters
    {
        public static void function_30_GettersESetters()
        {
            //getters e setters : getters e setters vengono usati per diminuire gli errori e aumentare la sicurezza del codice 
            //getters e setters : //1) creazione come metodi  , //2) creazione come propieta a mano  ,  //3) creazione con prop sulla classe 

           

            //metodo 1 
            Persona persona1 = new Persona("Luca","Rossi",25);
            persona1.SetNome("Marco");
            Console.WriteLine("persona1.GetNome() : " + persona1.GetNome());

            //metodo 2 
            Persona persona2 = new Persona("Luca", "Rossi", 25);
            persona2.Nome = "Anna";
            Console.WriteLine("persona2.Nome : " + persona2.Nome);

            // un altro vantaggio di usare i getters e setters e quello di andare a fare dei controlli all'interno ,
            // ad esempio per evitare di sostituire l'eta con valori negativi 

            persona2.SetEta(-2);
            Console.WriteLine("persona2.GetEta() : " + persona2.GetEta());


        }
    }

   
}

