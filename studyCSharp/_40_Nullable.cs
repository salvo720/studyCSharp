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
    internal class _40_Nullable
    {
        public static void function_40_Nullable()
        {
            //Nullable: e la possibilita di dare ad una variabile il valore null 
            //assegnare valori null ,casting da null , operatore ?? (Coalescing )

            //dichiarazione variabile null 
            int? prova = null;
            double? provaDouble = new double?();
            bool? provaBool = new bool?();

            bool? isMaschio = true;

            if (isMaschio == true) Console.WriteLine("isMaschio == true : sei maschio");
            else if (isMaschio == false) Console.WriteLine("isMaschio == false : sei femmina");
            else Console.WriteLine("isMaschio == null : sesso non specificato ");

            // passare una variabile null ad un int
            int? provaIntint = 2;
            int provaInt = (int)provaIntint;
            int? variabileInt =  prova;


            //operatore ?? (Coalescing)
            int provaIntvar = prova ?? 5; //quando usiamo l'operatore coalescing , la variabile di tipo opzionale viene automaticamente castata in int , se e null gli verra assegnato 5
            Console.WriteLine("provaIntvar : " + provaIntvar);

            int provaIntvariab = provaIntint ?? 5; //quando usiamo l'operatore coalescing , la variabile di tipo opzionale viene automaticamente castata in int , se e null gli verra assegnato 5
            Console.WriteLine("provaIntvariab : " + provaIntvariab);

        }
    }

   
}

