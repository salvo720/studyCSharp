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
    internal class _37_ModificatoriDiAccesso
    {
        public static void function_37_ModificatoriDiAccesso()
        {
            //Modificatori di accesso : 1) public , 2) protected , 3)  private , 4) internal | classe , altre classi , classe figlie , assembly  

            //1) public : possiamo usare la propieta o metodo ovunque 

            //2) protected : accessibili dalla stessa classe e dalle classi figlie ( o derivate )

            //3) private : possiamo usare la propieta o metodo solo all'interno della stessa classe in cui e dichiarato , 
            //ma possiamo inserirlo dentro un metodo public e quindi richiamabile avunque(speigare )

            //4) internal : e accessibli ovunque ma finche siamo all'interno dello stesso assembly 

            //modificatori di accesso : sono delle parole chaive che vanno a modificare l'accesso a metodi o propieta della classe , in diverse parti del nostro codice 

            Persona persona1 = new Studente("Luca","Rossi",20,"4A");
            persona1.Saluta(); // public 
            //persona1.Respira(); // protected
            //persona1.Cucina(); // private 
            persona1.Balla(); // internal 
        }
    }

   
}

