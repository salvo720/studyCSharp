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
    internal class _31_ParolaChiaveStatic
    {
        public static void function_31_ParolaChiaveStatic()
        {
            //static : 1) propieta static , 2) metodo static , 3) classe static  
            //1) propieta static : una propieta dell'oggetto 
            //2) metodo static : una propieta dell'oggetto 
            //3) classe static : non puo esere instanziata come oggetto 

            Persona persona1 = new Persona("Luca","Rossi",25);
            Persona persona2 = new Persona("Marco","Verdi",22);
            Persona persona3 = new Persona("Anna","Neri",20);

            //static : indica che ne esiste solo 1 copia 

            // 1) le propieta static della classe fanno riferimento alla classe e non all'oggetto 
            // e una propieta che vogliamo che sia condivisa tra tutti gli oggetti della classe persona 

            Console.WriteLine("persona1.cognome : " + persona1.cognome);
            Console.WriteLine("persona2.cognome : " + persona2.cognome);
            Console.WriteLine("persona3.cognome : " + persona3.cognome);
            Console.WriteLine("Persona.numeroPersone : " + Persona.numeroPersone);

            // 2) metodo static : creiamo un metodo static quando vogliamo accedere al metedo anche se non abbiamo creato nessun instanza di quella classe 
            Persona.Saluta2("Marco");

            // 3) classe static : la classe statica non puo essere instanziata , e uno strumento a cui possiamo accedere 
            // quindi il nostro obbiettivo e quello di accedere ai metodi senza andare ad isntanziare la classe 



        }
    }

   
}

