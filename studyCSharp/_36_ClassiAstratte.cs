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
    internal class _36_ClassiAstratte
    {
        public static void function_36_ClassiAstratte()
        {
            //classi astratte : sono delle classi che non posso essere utilizzate per la creazione di oggetti , quindi non possono essere instanziate direttamente 

            //abstract : prima di class , indica che si tratta di una classe astratta 

            //classe astratta : non possiamo instanziare un classe astratta 
            //metodi astratti : un metodo astratto e un metodo che non necessita di body , perche sara obbligatoriamente sovrascritto nella classe
            //che la estende ( propio come le interfacce , attenzione a non confonderle con le classi astrtte )

            //classi astrette vs interfacce : le classi astrttesono un mix con le interfacce , possono essere eredidate ma possiamo definire dei metodi o propieta
            //che necessariamente devono essere sovrascritte , questa e la differenza con le interfacce , dove tutti i metodi e propieta delle interfacce devono
            //essere obbligatoriamente sovrascritte 

            //le interfacce sono degli strumenti che possiamo applicare su piu classi , ed in modo multimplo ( piu di una )

            Abitante abitante1 = new Abitante("Luca", "Rossi", 20, 1990);
            abitante1.Saluta();


        }

        public class Abitante : PersonaAbstract
        {
            public string nome { get; set; }
            public string cognome { get; set; }
            public int eta { get; set; }
            public override int annoNascita { get; set; }



            public Abitante(string nome, string cognome, int eta, int annoNascita)
            {
                this.nome = nome;
                this.cognome = cognome;
                this.eta = eta;
                this.annoNascita = annoNascita;
            }


            public override void Saluta()
            {
                Console.WriteLine($"Abitante.Saluta() :  ciao io sono {nome} {cognome}");
            }
        }

        internal abstract class PersonaAbstract
        {
            abstract public int annoNascita { get; set; }

            public abstract void Saluta();
            public virtual void Respira()
            {
                Console.WriteLine("PersonaAbstract.Respira() : ");
            }

        }


    }
}

