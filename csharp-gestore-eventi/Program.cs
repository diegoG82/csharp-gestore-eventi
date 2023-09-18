﻿using csharp_gestore_eventi;

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

    Console.WriteLine("Inserisci la data dell'evento" + (i + 1) + ":");
    DateTime dataEvento = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci la capienza massima dell'evento:" + (i + 1) + ":");
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

            if (risposta == "no")
            {
                continua = false;
                continue;
            }

            Console.WriteLine("Indica il numero di posti da disdire:");

            int postiDaDisdire = int.Parse(Console.ReadLine());
            try
            {
                evento.DisdiciPosti(postiDaDisdire);
                Console.WriteLine($"Numero di posti ancora prenotatati = {evento.Postiprenotati}");
                Console.WriteLine($"numero di posti disdetti = {postiDaDisdire}");

                if (evento.Postiprenotati == 0)
                {
                    Console.WriteLine("Non ci sono piu' posti da disdire");
                    continua = false;
                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;

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
Console.WriteLine();
DateTime dataEventoRichiesto = DateTime.Parse(Console.ReadLine());
Console.WriteLine(ProgrammaEventi.StampaListaEventi(programma.ListaEventiPerData(dataEventoRichiesto)));









