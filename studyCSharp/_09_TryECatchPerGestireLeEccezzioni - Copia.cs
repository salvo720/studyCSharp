// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _09_OperatoriLogiciEDiComparazione
    {
        public static void function_09_OperatoriLogiciEDiComparazione()
        {
            Console.WriteLine("Inserisci il valore di numero 1");
            string numero1 = Console.ReadLine();
            int num1 = 0;
            try
            {
                num1=Int32.Parse(numero1);
            }
            catch (ArgumentNullException)
            {

                // throw;
                Console.WriteLine("numero 1 non puo essere vuoto o null");
            }
            catch (FormatException)
            {
                Console.WriteLine("numero 1 non puo essere di tipo stringa");

            }
            catch (OverflowException)
            {
                Console.WriteLine("numero 1 non puo contenere oltre 2 miliardi ( 2.000.000.000 )");
            }
            finally
            {
                //il blocco di finaly viene eseguito sempre dopo il catch , anche se avvengono eccezioni 
                Console.WriteLine("il lo scrivo a prescindere ");
            }
                Console.WriteLine("num1 + 2 : ");
                Console.WriteLine( num1 + 2);
        }
    }
}

