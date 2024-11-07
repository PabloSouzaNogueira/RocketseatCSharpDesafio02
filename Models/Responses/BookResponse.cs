using RocketseatCSharpDesafio02.Entities;

namespace RocketseatCSharpDesafio02.Models.Responses;

public class BookResponse
{
    public int BookId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public EnumBase.Genre Genre { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    internal static BookResponse? Convert(Book? book)
    {
        if (book == null)
            return null;

        var bookResponse = new BookResponse();
        bookResponse.BookId = book.BookId;
        bookResponse.Title = book.Title;
        bookResponse.Author = book.Author;
        bookResponse.Genre = book.Genre;
        bookResponse.Price = book.Price;
        bookResponse.Stock = book.Stock;

        return bookResponse;
    }
}