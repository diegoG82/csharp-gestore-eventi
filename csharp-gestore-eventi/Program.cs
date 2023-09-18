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
