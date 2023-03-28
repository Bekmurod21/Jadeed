using Jadeed.Domain.Entities;

namespace Jadeed.Data.IRepositories;

public interface IBookRepository
{
    ValueTask<Book> InsertBookAsync(Book book);
    ValueTask<Book> UpdateBookAsync(long id,Book book);
    ValueTask<bool> DeleteBookAsync(long id);
    ValueTask<Book> SelectBookAsync(Predicate<Book> predicate);
    IQueryable<Book> SelectAllBookAsync();
}
