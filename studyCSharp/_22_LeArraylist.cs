// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _22_LeArraylist
    {
        public static void function_22_LeArraylist()
        {
            // ArrayList : le arraylist sono una collezione di elementi che ha lunghezza variabile durate l'esecuzione del programma ( aggiungere o togliere elementi ) ,
            // e possono contenere tipi di dati diversi contemporaneamente  

            // creazione arraylist 
            ArrayList arrayList = new ArrayList();
            //aggiunto elemento singolo nell'arraylist 
            arrayList.Add(10);
            arrayList.Add("prova");

            ArrayList arrayList2 = new ArrayList() { 3,"prova3",true,4.5,null };
            Console.WriteLine("arrayList2[0] : " + arrayList2[0]);

            //ad un arraylist possiamo aggiungere un array o un altra array list 
            //1)array
            int[] numeriInteri = new int[] { 1,2,3,10,5,6,7,8 };
            arrayList.AddRange(numeriInteri);
            Console.WriteLine("arrayList[5]  : " + arrayList[5]);

            //2)arraylist 
            ArrayList arraylist3 = new ArrayList() { true };
            arraylist3.AddRange(arrayList2);

            Console.WriteLine("arraylist3[2] : " + arraylist3[2]);

            // insert
            arraylist3.Insert(0,"ciao");

            //assegnazione tramite indice 
            arraylist3[0] = false;
            Console.WriteLine("arraylist3[0] : " + arraylist3[0]);

            // Remove : Remove viene usato per rimuovere un eleemnto da un arraylist , quindi gli indici successivi veranno decrementati di -1 
            ArrayList arrayList4 = new ArrayList() { 10,20,30,40,50};
            arrayList4.Remove(30);
            Console.WriteLine("arrayList4[2] dopo remove 30 : " + arrayList4[2]);
            // Remove : removeAt viene usato per rimuovere un elemento in base all'indice 
            arrayList4.RemoveAt(0);
            Console.WriteLine("arrayList4[2] dopo Remove(30) e removeAt(0) : " + arrayList4[2]);

            ArrayList arrayList5 = new ArrayList() { 10, 20, 30, 40, 50 };
            //RemoveRange usa due parametri : 
            //1) indica la posizione iniziale 
            //2) indica gli elementi da rimuovere 
            arrayList5.RemoveRange(0,2);
            Console.WriteLine("arrayList5[2] RemoveRange(0,2) : " + arrayList5[2]);

            //contains : contains ritorna true o false in base al risulato della ricerca di un elemento 
      
            Console.WriteLine("arrayList5.Contains(50) : " + arrayList5.Contains(50));
            Console.WriteLine("arrayList5.Contains(10) : " + arrayList5.Contains(10));

            ArrayList arrayList6 = new ArrayList() { 10, "puma" , 30, 40, "oreo" };

            //foreach con le array list , possiamo usare var o object come tipo di dato , vanno bene entrambi 
            //var indica un tipo di dato variabile , simile al var di js 
            Console.WriteLine("foreach con var");
            foreach (var item in arrayList5)
            {
                Console.WriteLine("var item in arrayList5 : " +  item);
            }

            //object indica il tipo oggetto per la variabile item 
            Console.WriteLine("foreach con object");
            foreach (object item in arrayList5)
            {
                Console.WriteLine("object item in arrayList5 : " + item);
            }
            Console.WriteLine("for");
            for (int i = 0; i < arrayList5.Count; i++)
            {
                Console.WriteLine("arrayList5[i] : " + arrayList5[i]);
            }

            // le dimensione degli array sono fisse , mentre nelle arraylist possiamo aggiungere e rimuovere elementi 
            // gli array hanno un obbligo di tipo di dato , ovvero devono essere tutti dello stesso tipo , le arraylist invece non hanno nessun obblicgo sul tipo di dato  

        }
    }
}

