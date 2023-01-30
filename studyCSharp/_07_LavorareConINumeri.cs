// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _07_LavorareConINumeri
    {
        public static void function_07_LavorareConINumeri()
        {
            int a = 5;
            int b= 10;
            int c = a + b;
            double numero = 5.0;

            Console.WriteLine("c : "+ c + "\n");

            //per indicare la precedenza in una serie di operazioni si usano le parentesi tonde  , altrimenti c# eseguira le operazioni con la priorita matematiche standard

            int operazionimatematiche = ((5 + 6) * 29) / ( 33 - 22);

            int test = a++;

            //esegue test = 5 e ++ lo esegue dopo 

            int test2 = ++a;

            // esegue test2 = 1+5 = 6

            a += 5;


            Console.WriteLine("a : "+ a + "\n");

            // + con le stringhe adra ad effettuare una concatenazione anche se all'interno ci sono dei numeri quindi risultato sara "55" 

            string stringaA = "5";
            string stringaB = "5";
            string risultato = stringaA + stringaB;
            int stringaC = Int32.Parse(stringaA + stringaB); // andra ad effettuare l'operazione e dopo il parse quindi dobbiamo parsare le variabili o prima o singolarmente 

            //singolarmente 
            int stringaD = Int32.Parse(stringaA) + Int32.Parse(stringaB); // andra ad effettuare l'operazione e dopo il parse quindi dobbiamo parsare le variabili o prima o singolarmente 


            Console.WriteLine("a : "+ risultato + "\n");

            // metodi math :

            //1) ABS : e il valore assoluto quindi prendera solo la parte positiva di un numero 

            Console.WriteLine("Math.Abs(-40) : "+ Math.Abs(-40) + "\n");

            //2) POW : e la potenza , accetta 2 parametri di cui :
            //1) e il numero da elevare a potenza 
            //2) il valore della potenza 

            Console.WriteLine("Math.Pow(2,3) : "+ Math.Pow(2,3) + "\n");

            //3) MIN : e il valore minimo tra dei valori 

            Console.WriteLine("Math.Min(3,6) : "+ Math.Min(3,6) + "\n");

            //4) MAX : e la radice quadrata , sq sta per square = quadrato e rt per root , quindi radice quadrata 

            Console.WriteLine("Math.Max(3, 6) : "+ Math.Max(3, 6) + "\n");

            //5) SQRT : e la radice quadrata , sq sta per square = quadrato e rt per root , quindi radice quadrata 

            Console.WriteLine("Math.Sqrt(16) : "+ Math.Sqrt(16) + "\n");

        }
    }
}

