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
    internal class _35_IlPolimorfismo
    {
        public static void function_35_IlPolimorfismo()
        {
            //Polimorfismo:  significa piu ( da poli ) , siginifca forma ( da morfismo ) , quindi significa piu forme ovvero la capacita di un oggettto di avere piu forme 

            //il polimorfismo ci consente di usare come tipo di dato la classe da cui deriva l'oggetto che stiamo instanziando 

            var persone = new List<Persona>
            {
                new Insegnante ("Anna","Neri",35,"Sicurezza nelle reti "),            
                new Studente ("Marco","Verdi",28,"4A"),
            };

            foreach (var persona in persone)
            {
                persona.Saluta();
            }

            //new : la parola chiave new usata su un metodo indica di non sovrascrivere il precedente delle classe madre ma di averne un altro che sara richiamato per quel caso specifico 
            // la diffenrenza tra new e override : override sovrascrive il metodo della classe madre , new ne crea un altro che sara richiamato quando si chiama il metodo dalla nuova classe ,
            // se chiamiamo il metodo dalla vecchia classe verra usato il metodo originale 

            Console.WriteLine();
            Console.WriteLine("insegnante con metodo new , chiamiamo saluta : ");

            Insegnante insegnante1 = new Insegnante("Anna", "Neri", 35, "Sicurezza nelle reti ");
            insegnante1.Saluta();

            Persona studente1 = new Persona("Marco", "Verdi", 28);
            studente1.Saluta();
        }
    }

   
}

