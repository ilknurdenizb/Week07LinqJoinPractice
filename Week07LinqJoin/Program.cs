using System;
using Week07LinqJoin;
public class Program
{
    // This code demonstrates how to join two lists using LINQ in C#.
    static void Main ()
    {   // Define two Lists to represent Authors and Books
        List <Authors> authorList = new List<Authors>
        {
            new Authors { AuthorID = 1, AuthorName = "Orhan Pamuk" },
            new Authors { AuthorID = 2, AuthorName = "Elif Şafak" },
            new Authors { AuthorID = 3, AuthorName = "Ahmet Ümit" }
        };
        List<Books> bookList = new List<Books>
        {
            new Books {BookID = 1, BookTitle = "Kar", AuthorID = 1 },
            new Books {BookID = 2, BookTitle = "İstanbul", AuthorID = 1 },
            new Books {BookID = 3, BookTitle = "10 Minutes 38 Seconds in Strange World", AuthorID = 2 },
            new Books {BookID = 4, BookTitle = "Beyoğlu Rapsodisi", AuthorID = 3 }
        };
        // Perform a join operation between the two lists with AuthorIDs
        var query = from author in authorList
                    join book in bookList on author.AuthorID equals book.AuthorID
                    select new
                    {
                        AuthorName = author.AuthorName, // Select AuthorName from Authors
                        BookTitle = book.BookTitle      // Select BookTitle from Books
                    };
        // Display the results of the join operation
        Console.WriteLine("---Kitap ve Yazarlar Listesi--");
        // Iterate through the results and print each book with its author
        foreach (var item in query)
        {
            Console.WriteLine($"Kitap: {item.BookTitle}, Yazar: {item.AuthorName}");
        }
    }
}