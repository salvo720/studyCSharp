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
    internal class _24_LeHashtable
    {
        public static void function_24_LeHashtable()
        {

            // Hashtable : sono una collection ( insieme di elemnti ) , che contengono i valori in nel formato key => value , esempio : 
            // Hashtable["chiave"] = valore ;
            // le Hashtable non hanno l'obbligo della coerenza dei dati ( tutti dello stesso tipo )
            //le hashtable hanno elementi infiniti , ovvero possiamo aggingere o rimuovere elementi 

            //Hashtable: collection non fisse , non tipizzate , definite dal rapport chiave valore 


            //la  chiave delle hashtable non puo essere duplicata 
            //le chiavi delle hashtable possono essere anche numeri 

            //creazione 
            Hashtable prova = new Hashtable();
            Hashtable prova2 = new Hashtable() 
            {
                { "Lombardia","Milano"},
                { "Piemonte","Torino"},
                { "Liguria","Genova"},
                { "mentebianco",1},
                { 1 , true},
                { true , null},
                { false , 0 },
            };

            prova2.Add("veneto","venezia"); 
            
            //le Hashtable non supportano il metdo AddRange 
            // se usiamo una chiave duplicata il programma crushera 

            prova2["Lombardia"] = "Mantova";
            prova2.Remove("Piemonte");
            Console.WriteLine("prova2[\"Lombardia\"] : " + prova2["Lombardia"]);

            Console.WriteLine(" foreach prova2 : ");

            //DictionaryEntry = equivale a un inserimento nel dictionary , perche le hashtable hanno a che fare con i dictionary 
            foreach (DictionaryEntry citta in prova2)
            {
                Console.WriteLine($" { citta.Key } : {citta.Value }");
            }

            Console.WriteLine("prova2.ContainsKey(\"Lombardia\") : " + prova2.ContainsKey("Lombardia"));
            Console.WriteLine("prova2.ContainsValue(\"Milano\") : " + prova2.ContainsValue("Milano"));
        }
    }
}

