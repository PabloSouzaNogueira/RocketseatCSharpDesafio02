using RocketseatCSharpDesafio02.Entities;

namespace RocketseatCSharpDesafio02.Models.Responses;

public class BookRequest
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public int Genre { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    internal static Book Convert(BookRequest bookRequest)
    {
        var book = new Book();
        book.Title = bookRequest.Title;
        book.Author = bookRequest.Author;
        book.Price = bookRequest.Price;
        book.Stock = bookRequest.Stock;
        book.Genre = (EnumBase.Genre)bookRequest.Genre;

        return book;
    }

}