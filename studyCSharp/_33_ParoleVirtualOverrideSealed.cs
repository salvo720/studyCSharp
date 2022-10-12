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
    internal class _33_ParoleVirtualOverrideSealed
    {
        public static void function_33_ParoleVirtualOverrideSealed()
        {
            // Virtual : virtual si assegna ad un metodo e indica che puo essere sovrascritto 
            // Override : override si assegna al metodo quando lo andiamo a sovrascrivere , ( metodo che abbia usato virtual )
            // Sealed : indica chiuso , non apribile , viene applicato ad un metodo che effettua l'override ,
            // e indica che da quel punto in poi (se la classe ne estende un altra o erdita quel metdo ) , non potra piu sovrascrivere quel metodo  .
            //se applcihiamo seal ad una classe non avra classi derivate 

            Studente studente1 = new Studente("Luca","Rossi",20,"4A");
            studente1.Saluta();

            Insegnante insegnante1 = new Insegnante("Anna","Neri",28,"Storia");
            insegnante1.Saluta();

            InsegnateBallo insegnateBallo1 = new InsegnateBallo("Marco","Verdi",28,"House","Log in - Gemini");
            insegnateBallo1.Saluta();


            //base.nometodo() : possiamo andare a riprendere il metodo che andiamo a sovrascrivere dall'interno del metodo con override 
        }
    }

   
}

