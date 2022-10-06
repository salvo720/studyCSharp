// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _11_IfElse
    {
        public static void function_11_IfElse()
        {
            //if - else - if else - if annidati 
            int numero = 6;
            int numeroTest = 50;
            string stringaInput;
            if (numero == 5)
            {
                Console.WriteLine("numero vale : 5  ");
            } 
            else if (numero == 6)
            {
                Console.WriteLine("numero vale : 6  ");
            }
            else
            {
                Console.WriteLine("non so che numero sia ");
            }

            if (numeroTest % 2 == 0)
            {
                Console.WriteLine("il numeroTest e pari ");

                if ( numeroTest > 10 )
                {
                    Console.WriteLine("numeroTest e maggiore di 10");
                }
                else
                {
                    Console.WriteLine("numeroTest e minore di 10");
                }
            }
            else
            {
                Console.WriteLine("il numeroTest e dispari ");
            }

            Console.WriteLine("inserisci un valore ");
            stringaInput = Console.ReadLine();

            Console.WriteLine("stringaInput.GetType() : " + stringaInput.GetType()); //getType prende il typo di una variabile 

            int numeroInput = 0;
            try
            {
                numeroInput = Int32.Parse(stringaInput);
            }
            catch (Exception)
            {
                Console.WriteLine("si e verificato un errore , non e possibile convertire la variabile in int ");
                //throw;
            }

            if(numeroInput != 0)
            {
                Console.WriteLine(" la variabile in input e un numero ");
                if (numeroInput > 10)
                {
                    Console.WriteLine(" la variabile in input e maggire di 10 ");
                }
                else
                {
                    Console.WriteLine(" la variabile in input e minore di 10 ");
                }
            }
            else if (numeroInput == 0)
            {
                Console.WriteLine(" la variabile in input e una stringa  ");
            }

        }
    }
}

