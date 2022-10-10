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
    internal class _27_LeQueue
    {
        public static void function_27_LeQueue()
        {
            // Le queue (code )
            // Le queue : Le queue sono delle strutture Fifo 
            //Fifo : fist in first out 

            Queue<string> persone = new Queue<string>();
            persone.Enqueue("edo");
            persone.Enqueue("anna");
            persone.Enqueue("luca");
            persone.Enqueue("marco");
            persone.Enqueue("querty");
            Console.WriteLine("persone.Peek() : " + persone.Peek());
            persone.Dequeue(); // elimina l'elemento in picco 
            Console.WriteLine("persone.Peek() dopo Dequeue() : " + persone.Peek());

            //persone.Clear(); // la queue viene svuotata , ma e ancora possibile recuperarla
            Console.WriteLine("foreach persone : " );
            foreach (string persona in persone)
            {
                Console.WriteLine(persona);
            }

            Console.WriteLine("while persone : ");
            while (persone.Count > 0)
            {
                Console.WriteLine(" persone.Dequeue() : " + persone.Dequeue());
            }

            //Console.WriteLine("for persone : ");
            //for (; persone.Count > 0 ;)
            //{
            //    Console.WriteLine(" persone.Dequeue() : " + persone.Dequeue());
            //}
            // COMMENTATO PERCHE 2 CICLO di un elemneto gia svuotato 

        }
    }
}

