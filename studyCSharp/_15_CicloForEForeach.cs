// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _15_CicloForEForeach
    {
        public static void function_15_CicloForEForeach()
        {

            //Regola generale per quando usare for e while :
            //1)for : il for va usato quando conosciamo quante interazione andranno fatte 
            //2)while : il for va usato quando non conosciamo quante interazione andranno fatte 

            // la i all'interno del for ha block scope , quindi non possiamo usarala all'esterno 
            Console.WriteLine("for : ");
            for (int i=0;i<5;i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            int a = 2;
            //la j prima del while e una variabile normale con blockscope che e la funzione quindi possiamo usarla anche all'esterno 
            Console.WriteLine("while : ");
            while (j<a)
            {
                Console.WriteLine(j);
                j++;
            }

            //array 
            string[] nomi = { "edoardo", "luca", "marco", "giovanni" };

            //il tipo di dati che inseriamo nel foreach deve essere ugale a quello dell'array , 
            //ad esempio se abbiamo un array di tipo string quindi string[] sara di tipo string 
            Console.WriteLine("foreach : ");
            foreach ( string nome in nomi)
            {
                Console.WriteLine(nome);
            }
        
        }
    }
}

