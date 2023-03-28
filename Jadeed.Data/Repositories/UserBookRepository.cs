using Jadeed.Data.Context;
using Jadeed.Data.IRepositories;
using Jadeed.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jadeed.Data.Repositories;

public class UserBookRepository : IUserBookRepository
{
    AppDbContext appDbContext = new AppDbContext();
    public async ValueTask<bool> DeleteUserBookAsync(long id)
    {
        var entity = await appDbContext.UserBooks.FirstOrDefaultAsync(userbook => userbook.Id.Equals(id));
        if (entity is null)
            return false;

        appDbContext.UserBooks.Remove(entity);
        await appDbContext.SaveChangesAsync();
        return true;
    }
    public async ValueTask<UserBook> InsertUserBookAsync(UserBook userBook)
    {
        var entity = await appDbContext.UserBooks.AddAsync(userBook);
        await appDbContext.SaveChangesAsync();
        return entity.Entity;
    }
    public IQueryable<UserBook> SelectAllUserBookAsync()
    {
        var query = "select * from \"UserBooks\"";
        return appDbContext.UserBooks.FromSqlRaw(query);
    }
    public async ValueTask<UserBook> SelectUserBookAsync(Predicate<UserBook> predicate)
    {
        return await appDbContext.UserBooks.FirstOrDefaultAsync(userbook => predicate(userbook));
    }
    public async ValueTask<UserBook> UpdateUserBookAsync(UserBook userBook,long id)
    {
        userBook.Id=id;
        var entity =  appDbContext.UserBooks.Update(userBook);
        await appDbContext.SaveChangesAsync();
        return entity.Entity;
    }
}
