using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCSharp
{
    internal class Persona
    {
        private string nome;
        public string cognome;
        private int eta;

        //construttore
        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }
        public Persona(string cognome, int eta)
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

        // fine costruttore 

        //getter e setter metodo 1
        public void SetNome(string nome )
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome; ;
        }

        public void SetEta(int eta)
        {
            if(eta >= 0) this.eta = eta;
            else Console.WriteLine("Hai inserito un eta negativo , e imperdonabile!!!!! ");
        }

        public int GetEta()
        {
            return this.eta; ;
        }

        //getter e setter metodo 2 

        //public string Nome
        //{
        //    set => this.nome = value;
        //    get => this.nome ;
        //}

        //il getters e setters metodo 2 e commentato perche andrebbe in conflitto con il metodo 3 

        // getter e setter metodo 3 
        public string Nome { get; set; }


        public void Saluta(string nome = "nomefunzione")
        {
            // this : usare la parola chiave this all'interno di una classe fa in modo che la variaible a cui si fa riferimento
            // e quella della classe e non quella passata nella funzione 
            Console.WriteLine($"Ciao sono nome : {nome}");
            Console.WriteLine($"Ciao sono this.nome : {this.nome}");
        }
    }
}
