﻿using csharp_gestore_eventi;

Console.WriteLine("Benvenuto all'interno del Gestore eventi!");

Console.WriteLine("inserisci il nome della lista degli eventi:");
string NomeProgramma = Console.ReadLine();

Console.WriteLine("inserisci il numero degli eventi che vuoi creare: ");
int NumeroProgramma = int.Parse(Console.ReadLine());

ProgrammaEventi programma = new ProgrammaEventi(NomeProgramma);

for (int i = 0; i < NumeroProgramma; i++)
{
    Console.WriteLine("Inserisci il nome dell'evento " + (i + 1) + ":");
    string nomeEvento = Console.ReadLine();

    Console.WriteLine("L'evento è una conferenza? (si/no)");
    string rispostaConferenza = Console.ReadLine();

    bool isConferenza = rispostaConferenza == "si";

    Console.WriteLine("Inserisci la data dell'evento " + (i + 1) + ":");
    DateTime dataEvento = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci la capienza massima dell'evento " + (i + 1) + ":");
    int capienzaTotale = int.Parse(Console.ReadLine());

    Console.WriteLine("Quanti posti vuoi prenotare? ");
    int PostiPrenotati = int.Parse(Console.ReadLine());

    try
    {
        Evento evento;

        if (isConferenza)
        {
            int capienza = 100;
            int costoConferenza = 0;




            Console.WriteLine("Dimmi il nome del relatore:");
            string nomeRelatore = Console.ReadLine();

            Console.WriteLine("Dammi il costo evento:");
            costoConferenza = int.Parse(Console.ReadLine());

            Conferenza nuovaConferenza = new Conferenza(nomeEvento, dataEvento, capienza, PostiPrenotati, nomeRelatore, costoConferenza);
            evento = nuovaConferenza;




        }
        else
        {
            evento = new Evento(nomeEvento, dataEvento, capienzaTotale, PostiPrenotati);
        }

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


















