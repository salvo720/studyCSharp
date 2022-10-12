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
    internal class _38_GliEnumeratori
    {
        enum Mesi 
        { 
            Gennaio=1,Febbraio,Marzo,Aprile,Maggio,Giugno,
            Luglio,Agosto,Settembre,Ottobre,Novembre,Dicembre 
        };

        public static void function_38_GliEnumeratori()
        {
            // gli enumeratori o enum : gli enum sono una classe speciale che rappresenta un gruppo di costanti , quindi che non possono essere modificate e possiamo solo leggerle 

            // negli enam se mettiamo al primo valore =1 , partira a contare da 1 invece che da 0 

            //se mettiamo =4 al valore marzo , e cancelliamo =1 su gennaio , il valore su Dicembre sara 16 , perche dopo marzo = 4 , procede con aprile = 5 , ecc ... 
            Console.WriteLine(" (int)Mesi.Dicembre : " + (int)Mesi.Dicembre ); // se lo castiamo con int possiamo vedere in quale posizione si trova .
                                                                               // Nota Bene : fai prima un rapido check su =1 e se ci sta un = nell'enumerativo 
            Console.WriteLine(" Mesi.Dicembre : " + Mesi.Dicembre );

            //gli enum si usano quando abbiamo un gruppo di valori che sono sempre costanti , e che non cambierrano nel corso dello sviluppo 
            // ad esempio la qualita grafica : basso , medio , alto , ultra 

            Mesi meseNascita = Mesi.Aprile;

            switch (meseNascita)
            {
                case Mesi.Gennaio:
                    Console.WriteLine("switch (meseNascita) : Siamo in inverno");
                    break;
                case Mesi.Febbraio:
                    break;
                case Mesi.Marzo:
                    break;
                case Mesi.Aprile:
                    Console.WriteLine("switch (meseNascita) : Siamo in primavera");
                    break;
                case Mesi.Maggio:
                    break;
                case Mesi.Giugno:
                    break;
                case Mesi.Luglio:
                    Console.WriteLine("switch (meseNascita) : Siamo in estatate");
                    break;
                case Mesi.Agosto:
                    break;
                case Mesi.Settembre:
                    break;
                case Mesi.Ottobre:
                    Console.WriteLine("switch (meseNascita) : Siamo in autunno");
                    break;
                case Mesi.Novembre:
                    break;
                case Mesi.Dicembre:
                    break;
                default:
                    Console.WriteLine("switch (meseNascita) : non so in che stagione siamo ");
                    break;
            }

        }
    }

   
}

