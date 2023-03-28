using Jadeed.Data.Context;
using Jadeed.Data.IRepositories;
using Jadeed.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jadeed.Data.Repositories;

public class BookRepository : IBookRepository
{
    AppDbContext appDbContext = new AppDbContext();
    public async ValueTask<bool> DeleteBookAsync(long id)
    {
        var entity = await appDbContext.Books.FirstOrDefaultAsync(book => book.Id.Equals(id));
        if(entity is null) 
            return false;
        appDbContext.Books.Remove(entity);
        await appDbContext.SaveChangesAsync();
        return true;
    }

    public async ValueTask<Book> InsertBookAsync(Book book)
    {
        var entity = await appDbContext.Books.AddAsync(book);
        await appDbContext.SaveChangesAsync();
        return entity.Entity;
    }

    public IQueryable<Book> SelectAllBookAsync()
    {
        var query = "select * from \"Books\"";
        return appDbContext.Books.FromSqlRaw(query);
    }

    public async ValueTask<Book> SelectBookAsync(Predicate<Book> predicate)
    {
        return await appDbContext.Books.FirstOrDefaultAsync(book=>predicate(book));
    }

    public async ValueTask<Book> UpdateBookAsync(long id, Book book)
    {
        book.Id = id;
        var entity =  appDbContext.Books.Update(book);
        await appDbContext.SaveChangesAsync();
        return entity.Entity;
    }
}
