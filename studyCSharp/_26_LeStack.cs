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
    internal class _26_LeStack
    {
        public static void function_26_LeStack()
        {
            //Stack : gli stack sono Lifo , l'elemento piu in altro nella lifo si chiama Peek ( picco : ultimo elemento inserito )
            //Lifo : last in first out 
            // usando il metodo peek , non andiamo a rimuovere l'elemento ma solo a vederlo 
            Stack<int> inventario = new Stack<int>();
            inventario.Push(10); // aggiunge un elemento  
            inventario.Push(50);
            inventario.Push(80);
            inventario.Push(90);
            inventario.Push(100); 
            inventario.Pop(); // rimuove l'elemento piu in alto 
            Console.WriteLine("inventario.Peek() prima di clear : " + inventario.Peek());

            inventario.Clear();
            if(inventario.Count >= 0)
            {
                try
                {
                Console.WriteLine("inventario.Peek() dopo Clear() : " + inventario.Peek()); // se la stack e vuota effettuare il peek fara crushare il programma 

                }
                catch (Exception)
                {
                    Console.WriteLine("inventario vuoto ");
                }
            }
            else
            {
                Console.WriteLine("inventario vuoto ");
            }

            Stack<int> inventario2 = new Stack<int>();
            inventario2.Push(10); // aggiunge un elemento  
            inventario2.Push(50);
            inventario2.Push(80);
            inventario2.Push(90);
            inventario2.Push(100);
            inventario2.Pop();
            Console.WriteLine("foreach inventario2 : ") ;
            foreach (int item in inventario2)
            {
                Console.WriteLine(item);
            }

            inventario2.Pop();

            Console.WriteLine("foreach inventario2 dopo pop : ");
            foreach (int item in inventario2)
            {
                Console.WriteLine(item);
            }

            //try peek e try pop 

            // out indica che una funzione puo restituire dati multipli di tipi differenti ,se il valore della variabile cambia , cambia anche il valore del metodo 
            Console.WriteLine("inventario2.TryPeek(out int result) : " + inventario2.TryPeek(out int result));
            inventario2.TryPop(out int result2);

            Console.WriteLine("foreach inventario2 dopo pop e TryPop : ");
            foreach (int item in inventario2)
            {
                Console.WriteLine(item);
            }


        }
    }
}

