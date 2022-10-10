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
    internal class _28_ProgrammazioneAdOggettiOOP
    {
        public static void function_28_ProgrammazioneAdOggettiOOP()
        {
            // OOP : Object Oriented Programming 
            // propieta o attributo degli oggetti : sono le variabili di un oggetto 
            // metodo o funzione degli oggetti : sono funzioni che fanno parte di un oggetto
            // new : la parola chiave new e riservata per creare un nuovo oggetto 

            PersonaOld persona = new PersonaOld();
            persona.nome = "Marco";
            persona.Saluta();

        }
    }
    class PersonaOld
    {
        public string nome;

        public void Saluta(string nome = "nomefunzione")
        {
            // this : usare la parola chiave this all'interno di una classe fa in modo che la variaible a cui si fa riferimento
            // e quella della classe e non quella passata nella funzione 
            Console.WriteLine($"Ciao sono nome : {nome}");
            Console.WriteLine($"Ciao sono this.nome : {this.nome}");
        }
    }
}

