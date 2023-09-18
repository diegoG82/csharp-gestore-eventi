namespace csharp_gestore_eventi
{
    //CREO CLASSE EVENTO
    public class Evento
    {
        private string titolo;
        private DateTime data;

        private int capienza;
        private int postiprenotati;

        // COSTRUTTORE EVENTI
        public Evento(string titolo, DateTime data, int capienza)
        {
            Titolo = titolo;
            Data = data;
            Capienza = capienza;

            //COME RICHIESTO SI INIZIALIZZA IL NUMERO DEI POSTI PRENOTATI A 0
            postiprenotati = 0;
        }

        //IMPOSTO I GETTER:

        //TITOLO:
        public string Titolo
        {
            get { return titolo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Scrivere un titolo");
                }
                else
                {
                    titolo = value;
                }
            }
        }

        //DATA:
        public DateTime Data
        {
            get { return data; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("La data non puo' essere precedente a quella odierna");
                }
                else
                {
                    data = value;
                }
            }
        }

        //CAPIENZA
        public int Capienza
        {
            get
            {
                return capienza;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("La capienza deve essere superiore a zero");
                }
                else
                {
                    capienza = value;
                }
            }
        }

        //POSTI PRENOTATI

        public int Postiprenotati
        {
            get { return postiprenotati; }
        }


        //METODI

        //PRENOTAPOSTI

        public void PrenotaPosti(int posti)
        {
            //CASO EVENTO PASSATO
            if (data < DateTime.Now)
            {
                throw new Exception("Non e' possibile prenotare un'evento passato");
            }


            //PRENOTAZIONE
            if (posti <= Capienza - Postiprenotati)
            {
                postiprenotati += posti;
            }
            else
            {
                throw new Exception("Non c'e posto per l'evento");
            }

        }

        //DISDICIPOSTI


        public void DisdiciPosti(int posti)
        {
            //CASO EVENTO PASSATO
            if (data < DateTime.Now)
            {
                throw new Exception("Non e' possibile disdire un'evento passato");
            }

            //DISDETTA
            if (posti <= Postiprenotati)
            {
                postiprenotati -= posti;
            }


        }

        //OVERRIDE TO STRING PER STRINGA FORMATTATA CON DATA E TITOLO

        public override string ToString()
        {
            string dataformattata = Data.ToString("dd/MM/yyyy");
            return dataformattata + " - " + Titolo + " - " + " Capienza totale: " + Capienza + " Persone";
        }
    }
}
