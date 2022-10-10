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
    internal class _29_CostruttoreDellaClasse
    {
        public static void function_29_CostruttoreDellaClasse()
        {
            Persona persona1 = new Persona("Marco" , "Neri" , 25);
            Persona persona2 = new Persona("Luca" , "Rossi" , 25);
            Persona persona3 = new Persona("Rossi" , 25);
            Persona persona4 = new Persona(25);
            Persona persona5 = new Persona();


            //overloading : avere la stessa funzione piu volte purche cambia la firma o signature  , ovvero il numero o il tipo dei parametri 
            //overloading construct : eseguire l'overloading sul costruttore di una classe 
        }
    }

   
}

