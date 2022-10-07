// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _18_SovracccaricoDeiMetodiMethodOverloading
    {
        public static void function_18_SovracccaricoDeiMetodiMethodOverloading()
        {
            //Method overloading / sovraccarico  
            // Method Overloading : il method overloading e la possibilita di avere piu metodi con lo stesso nome , ma con signature ( firma ) diversa ,
            // ovvero con differenti paramentri ( tipo dei paramentri ) o quantita di parametri , e andra a richiamara quello giusto in base al tipo dei parametri o quantita  

            // i membri sono metodi e propieta di una classe 

            int risultato = Faisomma(10, 20);
            Console.WriteLine($" risultato e : {risultato} ");

            double result = Faisomma(20.00, 20.80);
            Console.WriteLine($" result e : {result} ");
        }

        public static int Faisomma(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Faisomma(int num1, double num2)
        {
            return num1 + num2;
        }

        public static double Faisomma(int num1, int num2 , int num3 )
        {
            return num1 + num2 + num3;
        }

        public static double Faisomma(double num1, double num2 )
        {
            return num1 + num2 ;
        }
    }
}

