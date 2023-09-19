namespace csharp_gestore_eventi
{
    public class Conferenza : Evento
    {
        private string titolo;
        private string relatore;
        private int prezzo;
        public Conferenza(string titolo, DateTime data, int capienza, int postiprenotati, string relatore, int prezzo) : base(titolo, data, capienza, postiprenotati)
        {
            this.relatore = relatore;
            this.prezzo = prezzo;
        }

        //GET e SET
        public string Relatore { get; set; }

        public int Prezzo { get; set; }

        public override string ToString()
        {
            string conferenza = base.ToString() + " " + "Il relatore della conferenza e': " + this.relatore + " " + "Il costo della suddetta e' di:  " + this.prezzo + " euro";
            return conferenza;
        }

    }
}
