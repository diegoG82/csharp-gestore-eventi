using csharp_gestore_eventi;

Evento evento;


Console.WriteLine("Benvenuto alla gestione delle fiere del fumetto 2023!");
Console.WriteLine();

Console.WriteLine("Inserisci il nome dell'evento: ");
string nomeEvento = Console.ReadLine();

Console.WriteLine("Inserisci la data dell'evento: ");
DateTime dataEvento = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la capienza dell'evento: ");
int capienzaTotale = int.Parse(Console.ReadLine());


//TEST READLINE
//Console.WriteLine($"il mio evento {nomeEvento} si svolge il {dataEvento} ed ha una capienza di {capienzaTotale} persone");

try
{
    evento = new Evento(nomeEvento, dataEvento, capienzaTotale);
    Console.WriteLine("Evento creato: " + evento.ToString()) ;
}

catch (Exception e)
{
    Console.WriteLine(e.Message);
    return;

}

Console.WriteLine("Quanti posti vuoi prenotare?");
int PostiPrenotati = int.Parse(Console.ReadLine());

try
{
    evento.PrenotaPosti(PostiPrenotati);
    Console.WriteLine($"Numero di posti prenotati = {evento.Postiprenotati}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine($"Posti rimanenti = {evento.Capienza - evento.Postiprenotati}");

bool continua = true;

while(continua)

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

        if(evento.Postiprenotati == 0)
        {
            Console.WriteLine("Non ci sono piu' posti da disdire");
            continua = false;
        }

     

    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }

}