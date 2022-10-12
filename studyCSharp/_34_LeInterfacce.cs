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
    internal class _34_LeInterfacce
    {
        public static void function_34_LeInterfacce()
        {
            // interfacce : sono una sorta di contratto che faccio firmare alla nostra classe per ottenere porpieta e metodi aggiuntivi ,
            // che non protrebbero ricevere in altro modo dalla classe madre

            //firmando il contratto le classi accettano di implementare quei metodi  ,ogni classe che lo accetta deve sovrascivere i metodi che ne derivano ( che gli vengono passati)

            //una classe puo estendere solo da una classe , ma puo estendere infinite interfacce 

            Studente studente1 = new Studente("Luca","Rossi",28,"4A");
            Studente studente2 = new Studente("Marco","Verdi",22,"4A");

            Console.WriteLine("studente2.Equals(studente1) : " + studente2.Equals(studente1));
        }
    }

   
}

