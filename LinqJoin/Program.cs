
// sample authors
List<Authors> authors = new List<Authors>
{
    new Authors { AuthorId = 1, Name = "Orhan Pamuk"},
    new Authors { AuthorId = 2, Name = "Ahmet Ümit" },
    new Authors { AuthorId = 3, Name = "Hakan Günay"}
};


// sample books
List<Books> books = new List<Books>
{
    new Books { BookId = 1, Title = "Benim Adım Kırmızı", AuthorId = 1 },
    new Books { BookId = 2, Title = "Masumiyet Müzesi", AuthorId = 1 },
    new Books { BookId = 3, Title = "Istanbul Hatırası", AuthorId = 2 },
    new Books { BookId = 4, Title = "Kinyas ve Kayra", AuthorId = 3 },
    new Books { BookId = 5, Title = "Az", AuthorId = 3 }
};

// LINQ query to join books and authors
var bookAuthorQuery = from book in books
                      join author in authors on book.AuthorId equals author.AuthorId
                      select new { BookTitle = book.Title, AuthorName = author.Name };

// display results
Console.WriteLine("Kitaplar ve Yazarları:");
foreach (var item in bookAuthorQuery)
{
    Console.WriteLine($"Kitap: {item.BookTitle}, Yazar: {item.AuthorName}");
}