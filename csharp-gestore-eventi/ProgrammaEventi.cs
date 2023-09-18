namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        private string titolo;

        private List<Evento> eventi;

        
            public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;

        this.eventi = new List<Evento>();
        }


        //METODI
    }
}
