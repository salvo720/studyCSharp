// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _05_CastingImplicitoEdEsplicito
    {
        public static void function_05_CastingImplicitoEdEsplicito()
        {
            //Casting :
            //1) impicito : c# consente di passare va un tipo piu piccolo ad uno piu grande , ad esempio da int a long , da int a float ,
            // ma non consente ad un tipo piu grande di diventare piu piccolo 
            int numero1 = 10;
            int lungo = numero1;

            //2) esplicito : viene usato per passare da un tipo piu grande ad uno piu piccolo , ad esempio da float a int 
            float fluttuante = 10.2598F;
            int floatInt = (int)fluttuante;

            //3) metodi di conversione : quando i tipi di dati non sono uguali o non sono della stessa categoria usiamo l'oggetto convert 

            int numero2 = 10;
            string stringa;
            //stringa = (string)numero2; // nota che andra in errore 
            stringa = Convert.ToString(numero2);


        }
    }
}

