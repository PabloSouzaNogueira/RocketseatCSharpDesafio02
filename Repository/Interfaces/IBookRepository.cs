using IusNatura.Cal.Application.Interfaces;

namespace RocketseatCSharpDesafio02.Entities;

public interface IBookRepository : IBaseRepository<Book>
{
    int? CreateBook(Book book);
    int? UpdateBook(int bookId, Book book);
    int? DeleteBook(int bookId);
}