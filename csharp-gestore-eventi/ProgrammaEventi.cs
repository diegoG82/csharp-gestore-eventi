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

        //Metodo per aggiungere alla lista un'evento
        public void AggiungiEvento(List<Evento> eventi)
        {
            foreach (Evento evento in eventi)
            {
                this.eventi.Add(evento);
            }
        }

        // Metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa data

        public List<Evento> ListaEventiPerData(DateTime data)
        {
            List<Evento> listaeventiperdata = new List<Evento>();
            foreach (Evento evento in this.eventi)
            {
                if (evento.Data == data.Date)
                {
                    listaeventiperdata.Add(evento);
                }
            }
            return listaeventiperdata;
        }

        // Metodo statico che si occupa, presa una lista di eventi, di stamparla in Console e restituisca una stringa della lista di eventi

        public static string StampaListaEventi(List<Evento> listaEventi)
        {
            string lista = "";

            if (listaEventi.Count == 0)
            {
                lista += "Nessun evento in lista \n ";
            }
            else
            {
                foreach (Evento evento in listaEventi)
                {
                    lista += evento.ToString() + "\n";
                }
            }
            return lista;
        }

        //Metodo che restituisce quanti eventi sono presenti nel programma evento attualmente

        public int NumeroEventi()
        {
            return this.eventi.Count;
        }

        //Metodo che svuota la lista di eventi

        public void CancellaLista()
        {
            this.eventi.Clear();
        }

        //un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli
        //eventi aggiunti alla lista.Come nell’esempio qui sotto:
        //Nome programma evento: data1 - titolo1

        public override string ToString()
        {
            string list = "";

            list += "IL Titolo del programma di eventi e': " + this.titolo + "\n";
            list += StampaListaEventi(this.eventi);
            return list;
        }

        public void StampaListaEventiPerData(DateTime data)
        {
            {
                List<Evento> eventiPerData = ListaEventiPerData(data);
                Console.WriteLine(StampaListaEventi(eventiPerData));
            }
        }

        public void AggiungiConferenza(Conferenza conferenza)
        {
            eventi.Add(conferenza);
        }


    

    }
}