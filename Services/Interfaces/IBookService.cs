using IusNatura.Cal.Application.Interfaces;
using RocketseatCSharpDesafio02.Models.Responses;

namespace RocketseatCSharpDesafio02.Entities;

public interface IBookService : IBaseService<Book>
{
    BookResponse? GetBook(int bookId);
    int? CreateBook(BookRequest bookRequest);
    int? UpdateBook(int bookId, BookRequest bookRequest);
    int? DeleteBook(int bookId);
}