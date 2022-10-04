// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;

namespace _04_TipiDiDati // Note: actual namespace depends on the project name.
{
    internal class _04_TipiDiDati
    {
        static void Main(string[] args)
        {
            string testo = "jasjdajkkdjka ajsdjajsdjasdj"; //stringa 
            char carattere = 'a'; //char 

            //note apici : string usa i doppi apici ( indica la presenza di piu caratteri ) , char i singoli ( indica la presenza di un solo carattere)

            int intero = 1000000000; // intero 
            long lungo = 100000000000000; // long 

            //numeri a virgola mobile :
            double doppio = 4.5; // dai 15 - 17 , double non richiede nessuna lettera dopo il valore
            float fluttuante = 4.5F; // dai 6 - 9 , float richiede una f dopo il numero ( maiscola o minuscola non e importante )
            decimal decimale = 4.5M; // 28 - 29  , decimal richiede una m dopo il numero ( maiscola o minuscola non e importante )

            //booleano 

            bool booleano = true; //booleano true o false 

            //note interi : gli interi vanno ad un massimo di 2 miliardi ( -2.000.000.000 a +2.000.000.000) 
            //note logn : i long ci permettono di superare i 2 miliardmi massimi imposti dal tipo int 

        }
    }
}

