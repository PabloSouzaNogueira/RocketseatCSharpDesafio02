using RocketseatCSharpDesafio02.Models.Responses;

namespace RocketseatCSharpDesafio02.Entities;

public class BookRepository : BaseRepository<Book>, IBookRepository
{
    public BookRepository(AppDbContext context) : base(context)
    {
    }

    public int? CreateBook(Book _book)
    {
        var book = Db.Books.Add(_book);

        Db.SaveChanges();

        return book.Entity.BookId;
    }

    public int? UpdateBook(int bookId, Book _book)
    {
        _book.BookId = bookId;
        var book = DbSet.Find(bookId);

        if (book == null)
            return null;

        var entry = Db.Entry(book);
        entry.CurrentValues.SetValues(_book);

        Db.SaveChanges();

        return bookId;
    }

    public int? DeleteBook(int bookId)
    {
        var book = DbSet.Find(bookId);

        if (book == null)
            return null;

        DbSet.Remove(book);
        return bookId;
    }
}