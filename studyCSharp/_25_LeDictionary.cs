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
    internal class _25_LeDictionary
    {
        public static void function_25_LeDictionary()
        {
         //Dictionary ( o Dict ) : sono delle collection , uguali alle hashtable ma richiedono la definizione specifica del tipo di chaive e valore
         Dictionary<string, string> prova = new Dictionary<string, string>();
         Dictionary<string, string> prova2 = new Dictionary<string, string>() 
         {
              { "Lombardia","Milano"},
              { "Piemonte","Torino"},
              { "Liguria","Genova"},
         };

            // le chiavi devono essere univoche o il programma crushera 

            prova2.Add("Veneto", "Venezia");
            prova2["Veneto"] = "Palermo";
            prova2.Remove("Piemonte");
            //prova2.Clear(); //pulisce il Dictionary eliminando tutto quello che si trova al suo interno 
            Console.WriteLine("prova2.ContainsKey(\"Piemonte\") :" + prova2.ContainsKey("Piemonte"));
            Console.WriteLine(" prova2.ContainsKey(\"Veneto\") : " + prova2.ContainsKey("Veneto"));
            Console.WriteLine("prova2.ContainsValue(\"Venezia\") : " + prova2.ContainsValue("Venezia"));
            Console.WriteLine("foreach prova2");
            foreach (KeyValuePair<string,string> citta in prova2)
            {
                Console.WriteLine($"{citta.Key} : {citta.Value} ");
            }
        }
    }
}

