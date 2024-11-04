// singer list
List<Singer> singers = new List<Singer>
{
     new Singer { FullName = "Ajda Pekkan", MusicGenre = "Pop", ReleaseYear = 1968, AlbumSales = 20 },
     new Singer { FullName = "Sezen Aksu", MusicGenre = "Türk Halk Müziği / Pop", ReleaseYear = 1971, AlbumSales = 10 },
     new Singer { FullName = "Funda Arar", MusicGenre = "Pop", ReleaseYear = 1999, AlbumSales = 3 },
     new Singer { FullName = "Sertab Erener", MusicGenre = "Pop", ReleaseYear = 1994, AlbumSales = 5 },
     new Singer { FullName = "Sıla", MusicGenre = "Pop", ReleaseYear = 2009, AlbumSales = 3 },
     new Singer { FullName = "Serdar Ortaç", MusicGenre = "Pop", ReleaseYear = 1994, AlbumSales = 10 },
     new Singer { FullName = "Tarkan", MusicGenre = "Pop", ReleaseYear = 1992, AlbumSales = 40 },
     new Singer { FullName = "Hande Yener", MusicGenre = "Pop", ReleaseYear = 1999, AlbumSales = 7 },
     new Singer { FullName = "Hadise", MusicGenre = "Pop", ReleaseYear = 2005, AlbumSales = 5 },
     new Singer { FullName = "Gülben Ergen", MusicGenre = "Pop / Türk Halk Müziği", ReleaseYear = 1997, AlbumSales = 10 },
     new Singer { FullName = "Neşet Ertaş", MusicGenre = "Türk Halk Müziği / Türk Sanat Müziği", ReleaseYear = 1960, AlbumSales = 2 }
};

// singer whose names start with 'S'
var startingWithS = singers.Where(s => s.FullName.StartsWith("S"));
Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
foreach (var singer in startingWithS) Console.WriteLine(singer.FullName);
Console.WriteLine();

// singers with album sales over 10 milion
var over10MillionSales = singers.Where(s => s.AlbumSales > 10);
Console.WriteLine("Albüm satışları 10 milyonun üzerinde olan şarkıcılar:");
foreach (var singer in over10MillionSales) Console.WriteLine($"{singer.FullName} - {singer.AlbumSales} milyon");
Console.WriteLine();

// pop singers who debuted before 2000 (listed according to their debut year)
var oldPopSingers = singers
    .Where(s => s.ReleaseYear < 2000 && s.MusicGenre.Contains("Pop"))
    .OrderBy(s => s.ReleaseYear)
    .ThenBy(s => s.FullName);
Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
foreach (var singer in oldPopSingers) Console.WriteLine($"{singer.FullName} - {singer.ReleaseYear}");
Console.WriteLine();

// best selling album artist
var bestSell = singers.OrderByDescending(s => s.AlbumSales).FirstOrDefault();
Console.WriteLine("En çok albüm satan şarkıcı:");
Console.WriteLine($"{bestSell.FullName} - {bestSell.AlbumSales} milyon");
Console.WriteLine();

// newest and oldest debut singer
var newestSinger = singers.OrderByDescending(s => s.ReleaseYear).FirstOrDefault();
var oldestSinger = singers.OrderBy(s => s.ReleaseYear).FirstOrDefault();
Console.WriteLine("En yeni çıkış yapan şarkıcı:");
Console.WriteLine($"{newestSinger.FullName} - {newestSinger.ReleaseYear}");
Console.WriteLine("En eski çıkış yapan şarkıcı:");
Console.WriteLine($"{oldestSinger.FullName} - {oldestSinger.ReleaseYear}");
