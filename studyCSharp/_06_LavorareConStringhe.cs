// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _06_LavorareConStringhe
    {
        public static void function_06_LavorareConStringhe()
        {
            string stringa = "prova \n\" si vive una volta sola \" ";
            // escape dei caratteri : per effettuare le'scape dei caratteri piazza un backslash prima degli apici doppi come sopra  ( \" )
            // creare una nuova riga : \n 
            // i caratteri di escape possono essere combinati insieme ad esempio : \n\"  

            Console.WriteLine("stringa : "+ stringa);

            //concatenazione : c# consnete di concatenate le variabili o delle stringhe usando l'operatore + .
            string nome = "Luca";
            string cognome = "Rossi";

            string testo = "ciao sono " + nome + " " + cognome;

            Console.WriteLine("testo : "+ testo + "\n");

            //format : usando format possiamo inserire dei segnaposto all'interno della stringa e successivamnete passare i valori dei segnaposto ,
            //in questo caso sono i numeri che indicano la posizione , esempio {0} lo 0 indica la prima variabile che gli passiamo in questo caso nome 

            string testo2 = string.Format("ciao sono {0} {1} ", nome , cognome);

            Console.WriteLine("testo2 : "+ testo2 + "\n");

            // interpolazione : l'interpolazione e la sostituzione del testo con delle variabili , su c# puoi farlo aggiungendo il carattere $ prima della stringa
            // e la variabile va indicata tra le parentesi graffe  

            string testo3 = $"ciao sono {nome} {cognome} ";

            Console.WriteLine("testo3 : "+ testo3 + "\n");

            //metodi : possiamo eseguire dei metodi sulle stringhe e sono 

            //1) ToUpper : modifica il testo tutto in maiuscolo 

            string testoUpper = nome.ToUpper();
            Console.WriteLine("testoUpper : "+ testoUpper + "\n");

            //2) ToLower :

            string testoLower = nome.ToLower();
            Console.WriteLine("testoUpper : "+ testoLower + "\n");

            //3) Lenght : Lenght ritorna la lunghezza della stringa ricorda che e un numero

            string stringavuota = "";

            int numeroStringa = stringavuota.Length;
            Console.WriteLine("stringavuota : "+ stringavuota + "\n");

            //4) Indexing : andare a prendere un carattere da un stringa in base al suo indice 

            Console.WriteLine("nome[0] : "+ nome[0] + "\n");
            // Ricorda che l'ultimo carattere della stringa sara sempre = a stringa.Lenght -1 
            // il primo elemento di una stringa e 0 

            //5) IndexOf : ricorca uno o piu caratteri nella stringa e ritorna la sua posizione 

            Console.WriteLine("nome.IndexOf(\"c\") : "+ nome.IndexOf("c") + "\n");


            //6) Substring : taglia la stringa e ne prende la parte dopo l'indice specificato 

            Console.WriteLine("nome.Substring(2) : "+ nome.Substring(2) + "\n");

            //Per sottrare partendo dalla fine ci basta dare come primo parametro la stringa.lenght e -3 (il punto fino a cui dobbiamo prendere) 

            Console.WriteLine("nome.Substring(2) : "+ nome.Substring(nome.Length - 3) + "\n");


        }
    }
}
