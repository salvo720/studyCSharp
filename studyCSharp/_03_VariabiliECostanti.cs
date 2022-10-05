using System;

public class _03_VariabiliECostanti
{
    public _03_VariabiliECostanti()
    {
        static void Main(string[] args)
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
