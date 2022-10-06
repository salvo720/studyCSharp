// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _10_OperatoriLogiciEDiComparazione
    {
        public static void function_10_OperatoriLogiciEDiComparazione()
        {
            //operatori di comparazione : < > <= >= == != 
            //logici : &&  ||  ! 
            // && ( entrambe le condizioni vere per fare true )
            // || ( almeno una condizione vera per fare true )
            // ! ( prede il valore opposto , ovvero not , quindi se vale true sara false )


            int tagliaDisponibile = 39;
            string coloreDisponibile = "nero";

            Console.WriteLine("6 <= 6 :" );
            Console.WriteLine(6 <= 6);
            Console.WriteLine(" tagliaDisponibile == 39 && (coloreDisponibile==\"nero\" || coloreDisponibile==\"rosso\") : " + ( tagliaDisponibile == 39 && (coloreDisponibile=="nero" || coloreDisponibile=="rosso" )) );
            //tagliaDisponibile == 39 && coloreDisponibile == "nero" || coloreDisponibile == "rosso" , stai attento perche la condizione del commento e quella nel writeline non sono uguali , 
            //il codice potrebbe non funzionare , nota le parentesi che mettono && e || su due piani diversi e non sullo stesso piano esempio : 
            // nel writeline (vero && ( vero || false )) = vero && vero = vero
            // nel writeline (vero && ( false || vero )) = vero && vero = vero

            // nel commento ( vero && vero || false ) = vero 
            // nel commento(vero && false || vero ) = false

        }
    }
}

