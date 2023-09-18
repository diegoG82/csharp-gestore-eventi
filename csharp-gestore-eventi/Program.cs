using csharp_gestore_eventi;

Console.WriteLine("Benvenuto alla gestione delle fiere del fumetto 2023!");
Console.WriteLine();

Console.WriteLine("inserisci il nome della lista degli eventi:");
string NomeProgramma = Console.ReadLine();


Console.WriteLine("inserisci il numero degli eventi che vuoi creare: ");
int NumeroProgramma = int.Parse(Console.ReadLine());

ProgrammaEventi programma = new ProgrammaEventi(NomeProgramma);


for (int i = 0; i < NumeroProgramma; i++)
{
    Console.WriteLine("Inserisci il nome dell'evento " + (i + 1) + ":");
    string nomeEvento = Console.ReadLine();

    Console.WriteLine("Inserisci la data dell'evento " + (i + 1) + ":");
    DateTime dataEvento = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci la capienza massima dell'evento" + (i + 1) + ":");
    int capienzaTotale = int.Parse(Console.ReadLine());

    Console.WriteLine("Quanti posti vuoi prenotare?");
    int PostiPrenotati = int.Parse(Console.ReadLine());

    try
    {
        Evento evento = new Evento(nomeEvento, dataEvento, capienzaTotale, PostiPrenotati);

        List<Evento> listaEventi = new List<Evento> { evento };

        programma.AggiungiEvento(listaEventi);

        Console.WriteLine($"Numero di posti prenotati = {evento.Postiprenotati}");
        Console.WriteLine($"Posti rimanenti = {evento.Capienza - evento.Postiprenotati}");

        bool continua = true;

        while (continua)

        {
            Console.WriteLine("Vuoi disdire dei posti? (si/no)");
            string risposta = Console.ReadLine();


            if (risposta == "si")
            {
                Console.WriteLine("Indica il numero di posti da disdire:");
                int postiDaDisdire = int.Parse(Console.ReadLine());
                evento.DisdiciPosti(postiDaDisdire);
                Console.WriteLine($"Numero di posti ancora prenotatati = {evento.Postiprenotati}");
                Console.WriteLine($"numero di posti disdetti = {postiDaDisdire}");
            }

            else if (risposta == "no")
            {
                Console.WriteLine("Procediamo alle fase successiva");
                Console.WriteLine();
                continua = false;
                continue;
            }

        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return;

    }

}

//NUMERO DI EVENTI CREATI
Console.WriteLine($"Il numero di eventi creati e': {programma.NumeroEventi()} ");
Console.WriteLine();

//STAMPA A STRINGA DELLA LISTA EVENTI
Console.WriteLine(programma.ToString());
Console.WriteLine();

//RICERCA EVENTO PER DATA
Console.WriteLine("Inserisci una data per cercare un'evento (gg/mm/yyyy): ");

DateTime dataEventoRichiesto = DateTime.Parse(Console.ReadLine());
programma.StampaListaEventiPerData(dataEventoRichiesto);
Console.WriteLine();

//BONUS

Console.WriteLine("Ecco il gestore delle conferenze!");

Console.Write("Nome della conferenza: ");

string conferenza = Console.ReadLine();

Console.Write("Inserisci la data della conferenza(gg/mm/yyyy): ");

DateTime dataConferenza = DateTime.Parse(Console.ReadLine());

Console.Write("Inserisci i posti della tua conferenza: ");

int postiConferenza = int.Parse(Console.ReadLine());
int postiPrenotati = 0;

Console.Write("Inserisci il nome del relatore: ");
string nomeRelatore = Console.ReadLine();

Console.Write("Inserisci il prezzo della conferenza: ");
int costoConferenza = int.Parse(Console.ReadLine());

Conferenza nuovaConferenza = new Conferenza(conferenza, dataConferenza, postiConferenza, postiPrenotati, nomeRelatore, costoConferenza);

programma.AggiungiConferenza(nuovaConferenza);

Console.WriteLine("Ecco il programma eventi con anche le conferenze!");
Console.WriteLine(programma.ToString());






