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
    internal class _23_LeList
    {
        public static void function_23_LeList()
        {

            //  fanno parte delle Collection : List , ArrayList , Array , Dictionary , Hashtable , Stack , Queue ;

            // tipo dato coerente = hanno un tipo di dato coerente

            //le List : sono il contrario delle Arraylist
            //Array : finiti elemeneti , e si tipo dato coerente
            //ArrayList :  infiniti elementi , che possiamo rimuovere e aggiungere , e si tipo dato coerente  ( esempio :string e int insieme )
            //le List :  infiniti elementi , che possiamo rimuovere e aggiungere , e no tipo dato coerente  ( esempio : solo string , solo int )
            int[] arrayInteri = { 10, 20, 30 };
            string[] arrayString = { "testo1", "testo2", "testo3" };
            List<int> list1 = new List<int>(){ 1, 2, 3, 4 };

            list1.Add(5);
            list1.AddRange(arrayInteri);
            //list1.AddRange(arrayString); //va in errore questo conferma che il tipo di dato deve essere coerente 
            list1.Insert(0, 55); //inserisce e auemnta l'indice degli altri elementi 
            list1[0] = 5000;
            list1.Remove(5000);
            list1.RemoveAt(0);
            list1.RemoveRange(0, 4); // 1) parametro la poszioni da cui iniziare 2) parametro gli elementi da rimuovere   
            Console.WriteLine("list1[0] operazioni - 4 aggiunta , 3 rimozione : " + list1[0]);

            // Clear 
            //list1.Clear(); // remove all element from list 

            // Count 
            //list1.Count; // Conta tutti gli elemti della list  

            Console.WriteLine("list1.Contains(10) : " + list1.Contains(10));
            Console.WriteLine("list1.Contains(55) : " + list1.Contains(55));

            Console.WriteLine("foreach : ");
            foreach (var item in list1)
            {
                Console.WriteLine("item in list1 : " + item);

            }

            Console.WriteLine("for : ");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine("( list1[i] +1 ) : " + (list1[i] + 1));
            }
         
        }
    }
}

