using CET322_HW.Migrations;
using CET322_HW.Models;
using Microsoft.EntityFrameworkCore;


Publisher publisher = new Publisher()
{
    Name = "Orhan Veli Kanýk",
    //Id = 1,
    UserScore = 4.8,
    BirthDate = new DateTime(1925,01,01), 

};




Book book = new Book()
{
    Name = "Bütün Þiirleri",
    PublisherName = "Orhan Veli Kanýk",
    //Id = 1,
    UserScore = 3.9,
    PublishedDate = new DateTime(1950, 01, 01),
};



PublisherDataContext db = new PublisherDataContext();
db.Publishers.Add(publisher);
db.SaveChanges();


BookDataContext db2 = new BookDataContext();
db2.Books.Add(book);
db2.SaveChanges();




/////////////////////////////////////////////////////////////////////////////////////////

/*
// INSERT A BOOK
Book book = new Book()
{
    Name = "Garip",
    PublisherName = "Orhan Veli Kanýk",
    UserScore = 3.7,
    PublishedDate = new DateTime(1955, 01, 01)
};



PublisherDataContext db1 = new PublisherDataContext();
Publisher publisher = db1.Publishers.FirstOrDefault(p => p.Name == book.PublisherName);



BookDataContext db2 = new BookDataContext();
db2.Books.Add(book);
db2.SaveChanges();
*/

/////////////////////////////////////////////////////////////////////////////////////////

/*
// UPDATE A BOOK
BookDataContext db2 = new BookDataContext();


Book bookToUpdate = db2.Books.FirstOrDefault(b => b.Id == 17);


if (bookToUpdate != null)
{
    bookToUpdate.Name = "Yalnýz Seni Arýyorum";
    bookToUpdate.UserScore = 3.6;

    db2.SaveChanges();
}
*/

/////////////////////////////////////////////////////////////////////////////////////////

/*
// GET A BOOK WITH ID
BookDataContext db2 = new BookDataContext();

var book = db2.Books
            .Where(b => b.Id == 14)
            .Select(b => new { b.Name, b.PublisherName, b.UserScore, b.PublishedDate })
            .FirstOrDefault();

if (book != null)
{
    Console.WriteLine("Book Name: " + book.Name);
    Console.WriteLine("Publisher Name: " + book.PublisherName);
    Console.WriteLine("User Score: " + book.UserScore);
    Console.WriteLine("Published Date: " + book.PublishedDate);
}

else
{
    Console.WriteLine("Book not found!");
}
*/

/////////////////////////////////////////////////////////////////////////////////////////


// GETTING ALL THE BOOKS
/*
BookDataContext db2 = new BookDataContext();

List<Book> allBooks = db2.Books.ToList();

foreach (Book book in allBooks)
{
    Console.WriteLine("Book Id: " + book.Id);
    Console.WriteLine("Book Name: " + book.Name);
    Console.WriteLine("Publisher Name: " + book.PublisherName);
    Console.WriteLine("User Score: " + book.UserScore);
    Console.WriteLine("Published Date: " + book.PublishedDate);
}
*/

/*
using (var db = new BookDataContext())
{
    var books = db.Books.Include(b => b.Publisher).ToList();

    foreach (var book in books)
    {
        Console.WriteLine("Book Name: " + book.Name);
        Console.WriteLine("Publisher Name: " + book.Publisher.Name);
        Console.WriteLine("User Score: " + book.UserScore);
        Console.WriteLine("Published Date: " + book.PublishedDate);
        Console.WriteLine();
    }

    var publishers = db.Publishers.Include(p => p.Books).ToList();

    foreach (var publisher in publishers)
    {
        Console.WriteLine("Publisher Name: " + publisher.Name);
        Console.WriteLine("User Score: " + publisher.UserScore);
        Console.WriteLine("Birth Date: " + publisher.BirthDate);
        Console.WriteLine("Books Published:");

        foreach (var book in publisher.Books)
        {
            Console.WriteLine("- " + book.Name);
        }

        Console.WriteLine();
    }
}
*/