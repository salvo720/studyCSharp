using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCSharp
{
    // nota dopo insegnate (Insegnante: Persona , i due punti dopo una classe indicano che ne sta estendendo un altra , la classe dopo i : e la classe che estendiamo )
    internal class Insegnante: Persona
    {
        public string materia;

        // nota i : dopo il costruttore  (  Insegnante(string nome, string cognome , int eta , string materia) : base( nome , cognome , eta ) ) ,
        // indicano che stiamo passando i dati alla classe padre tramtie la funzione base ( simile al super di java ) 
        public Insegnante(string nome, string cognome , int eta , string materia) : base( nome , cognome , eta )
        { 
            this.materia = materia;
        }

        public void insegna()
        {

        }

        //public sealed override void Saluta()
        public new void Saluta()
        {
            //base.Saluta(); //andiamo a riprende ed eseguire il metodo di cui eseguiamo l'override 
            Console.WriteLine("Insegnante.Saluta() : Buongiorno Ragazzi !!!!! ");
        }
    }
}
