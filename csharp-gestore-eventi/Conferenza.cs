using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Conferenza : Evento
    {
        private static string titolo;
        private string relatore;
        private int prezzo;
        public Conferenza(string titolo, DateTime data, int capienza, int postiprenotati, string relatore, int prezzo): base(titolo, data, capienza, postiprenotati)
        {
            this.relatore = relatore;
            this.prezzo = prezzo;
        }

        //GET e SET
        public string Relatore { get; set; }

        public int Prezzo { get; set; }

        public override string ToString()
        {
            string conferenza = base.ToString() + " " + this.relatore + " " + this.prezzo + " euro" ;
            return conferenza;
        }

    }
}
 