using RocketseatCSharpDesafio02.Models.Responses;
using System.Net;

namespace RocketseatCSharpDesafio02.Entities;

public class BookService : BaseService<Book>, IBookService
{
    readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository) : base(bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public BookResponse? GetBook(int bookId)
    {
        var book = _bookRepository.Find(x => x.BookId == bookId).FirstOrDefault();
        return BookResponse.Convert(book);
    }

    public int? CreateBook(BookRequest bookRequest)
    {
        var book = BookRequest.Convert(bookRequest);
        return _bookRepository.CreateBook(book);
    }

    public int? UpdateBook(int bookId, BookRequest bookRequest)
    {
        var book = BookRequest.Convert(bookRequest);
        return _bookRepository.UpdateBook(bookId, book);
    }

    public int? DeleteBook(int bookId)
    {
        return _bookRepository.DeleteBook(bookId);
    }
}