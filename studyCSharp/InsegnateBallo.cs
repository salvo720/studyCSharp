using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCSharp
{
    internal class InsegnateBallo: Insegnante
    {
        public string canzonePreferita;

        public InsegnateBallo(string nome , string cognome ,int eta , string materia ,  string canzonePreferita ) : base( nome , cognome , eta , materia  ) 
        {
            this.canzonePreferita = canzonePreferita;
        }

        //Commentato perche usiamo sealed su insegnate , quindi non e piu possibile eseguire l'override di saluta 
        //public override void Saluta()
        //{
        //    Console.WriteLine("InsegnateBallo.Saluta() : Buongiorno ballerini!!!!");
        //}
    }
}
