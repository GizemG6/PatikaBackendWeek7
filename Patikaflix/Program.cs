
List<TVShow> tvShows = new List<TVShow>(); // tv show list
string addAnother; // tv shows to be added

do
{
    // create a new TV show
    TVShow show = new TVShow();

    Console.Write("Dizinin ismini giriniz: ");
    show.Name = Console.ReadLine();

    Console.Write("Yapım yılını giriniz: ");
    show.ReleaseYear = int.Parse(Console.ReadLine());

    Console.Write("Türünü giriniz: ");
    show.Genre = Console.ReadLine().ToLower();

    Console.Write("Yayınlanmaya başlama yılı giriniz: ");
    show.StartYear = int.Parse(Console.ReadLine());

    Console.Write("Yönetmen: ");
    show.Director = Console.ReadLine();

    Console.Write("Yayınlandığı İlk Platform: ");
    show.Platform = Console.ReadLine();

    // add the show to the list
    tvShows.Add(show);

    // ask if user wants to add another show
    Console.Write("Eklemeye devam etmek istiyor musun?(yes/no): ");
    addAnother = Console.ReadLine().ToLower();

} while (addAnother == "yes");

// filtering comedy shows
var comedyShows = tvShows
    .Where(s => s.Genre.Contains("komedi"))
    .Select(s => new { s.Name, s.Genre, s.Director })
    .OrderBy(s => s.Director)
    .ThenBy(s => s.Name)
    .ToList();

// printing comedy shows
Console.WriteLine("Komedi Türündeki Dizilerin Listesi:");
foreach (var show in comedyShows)
{
    Console.WriteLine($"İsmi: {show.Name}, Türü: {show.Genre}, Yönetmen: {show.Director}");
}

// display the list of TV shows
Console.WriteLine("\nTüm Diziler:");
foreach (var show in tvShows)
{
    Console.WriteLine($"İsmi: {show.Name}, Yönetmen: {show.Director}, Türü: {show.Genre}, Yılı: {show.StartYear}, Platform: {show.Platform}");
}