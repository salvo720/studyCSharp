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
    internal class _39_LavorareConLeDate
    {
        public static void function_39_LavorareConLeDate()
        {

            //Lavorare con le date (datetime)
            //creare una data , oggi , adesso , propieta , kind 
            // aggiungere , sottrarre , formattazione
            // 

            DateTime data = new DateTime();
            Console.WriteLine("data ( DateTime() ) : " +  data); // 01/01/0001 00:00:00 punto da cui iniza a contare per le date 

            DateTime data1 = new DateTime(2021, 10, 10, 12, 39, 45);
            Console.WriteLine("data1 ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1);

            Console.WriteLine("data1.Year ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.Year);
            Console.WriteLine("data1.Day ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.Day);
            Console.WriteLine("data1.DayOfWeek ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.DayOfWeek);
            Console.WriteLine("data1.DayOfYear ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.DayOfYear); // giorni alla fine dell'anno 
            Console.WriteLine("data1.Minute ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.Minute); 
            Console.WriteLine("data1.AddDays(11) ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.AddDays(11)); // aggiunge 11 giorni alla data attuale 
            //possiamo  andare a combinare le varie propeta 
            Console.WriteLine("data1.AddYears(2) ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.AddYears(2).DayOfWeek); // aggiunge 2 anni alla data attuale e prende il giorno della settimana 

            DateTime data2 = new DateTime(2021, 2, 10);
            Console.WriteLine("data1.Subtract(data2) ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.Subtract(data2)); // aggiunge 2 anni alla data attuale e prende il giorno della settimana 
            Console.WriteLine("data1.ToString(\"D\") ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.ToString("D")); // 
            Console.WriteLine("data1.ToString(\"f\") ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.ToString("f")); // 
            Console.WriteLine("data1.ToString(\"F\") ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.ToString("F")); // 
            Console.WriteLine("data1.ToString(\"u\") ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.ToString("u")); // la Z alla fine della data indica che e un universal time zone (utc)
            Console.WriteLine("data1.ToString(\"dddd , dD ,MMMM\") ( DateTime(2021, 10, 10, 12, 39, 45); )  : " + data1.ToString("dddd , dD ,MMMM")); // combinati 


            // DateTime:
            Console.WriteLine("DateTime.UtcNow : " + DateTime.UtcNow);  //.UtcNow: si basa su greenwich , quindi l'ora sara 1 ora indietro rispetto all'italia 
            Console.WriteLine("DateTime.Now : " + DateTime.Now);  //.Now: prende data e ora di adesso
            Console.WriteLine("DateTime.Today : " + DateTime.Today); //  .Today : prende la data di oggi 
            Console.WriteLine();

        }
    }

   
}

