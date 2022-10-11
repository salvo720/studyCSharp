using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCSharp
{
    // nota dopo insegnate (Studente: Persona , i due punti dopo una classe indicano che ne sta estendendo un altra , la classe dopo i : e la classe che estendiamo )
    internal class Studente: Persona 
    {
        public string classe;

        // nota i : dopo il costruttore  (  Studente(string nome , string cognome , int eta , string classe): base( nome,  cognome,  eta) ) ,
        // indicano che stiamo passando i dati alla classe padre tramtie la funzione base ( simile al super di java ) 
        public Studente(string nome , string cognome , int eta , string classe): base( nome,  cognome,  eta)
        {
            this.classe = classe;
        }

        public void Studia() 
        {
        
        }
    }
}
