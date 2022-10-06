using System;

namespace studyCSharp
{
    internal class _03_VariabiliECostanti
    {
        public static void function_03_VariabiliECostanti()
        {
            //inizializzazione
            string nome1 = "Luca";

            //dichiarazione
            string cognome1;

            //assegnazione
            cognome1 = "Rossi";

            //riassegnazione 
            const string nome = "Marco";
            string cognome = "Verdi";
            int eta = 18;


            Console.WriteLine("Ciao io sono" + nome);
            Console.WriteLine("Ho " + eta + " anni");
            Console.WriteLine(nome + " e il mio primo nome ");

            Console.WriteLine("sono nato il 25 novembre ");
            // Console.Read(); ci consente di mantenere  il programma in esecuzione perche aspetta un input dell'utente 
            Console.Read();


        }
    }
}





