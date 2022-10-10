using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCSharp
{
    internal class Persona
    {
        public string nome;
        public string cognome;
        public int eta;
        
        //construttore
        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }
        public Persona( string cognome, int eta)
        {
            this.cognome = cognome;
            this.eta = eta;
        }
        public Persona(int eta)
        {
            this.eta = eta;
        }
        public Persona()
        {
          
        }

        public void Saluta(string nome = "nomefunzione")
        {
            // this : usare la parola chiave this all'interno di una classe fa in modo che la variaible a cui si fa riferimento
            // e quella della classe e non quella passata nella funzione 
            Console.WriteLine($"Ciao sono nome : {nome}");
            Console.WriteLine($"Ciao sono this.nome : {this.nome}");
        }
    }
}
