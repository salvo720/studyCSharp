// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _13_CostruttoSwitchCase
    {
        public static void function_13_CostruttoSwitchCase()
        {

            int eta = 18;
            string nome = "Luca";

            switch (eta)
            {
                case 18:
                    if (nome=="Luca")
                    {
                        Console.WriteLine(nome + " sei maggiorenne 18");
                    }
                    break;
                case 20:
                    Console.WriteLine("sei un ventenne");
                    break;
                case 30:
                    Console.WriteLine("la vecchiaia avanza");
                    break;
                default:
                    Console.WriteLine("la tua eta non e tra i casi previsti");
                    break;
            }

        }
    }
}

