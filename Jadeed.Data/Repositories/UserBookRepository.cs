using Jadeed.Data.Context;
using Jadeed.Data.IRepositories;
using Jadeed.Domain.Entities;

namespace Jadeed.Data.Repositories;

public class UserBookRepository : IUserBookRepository
{
    AppDbContext appDbContext = new AppDbContext();
    public ValueTask<bool> DeleteUserBookAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserBook> InsertUserBookAsync(UserBook userBook)
    {
        throw new NotImplementedException();
    }

    public ValueTask<List<UserBook>> SelectAllUserBookAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserBook> SelectUserBookAsync(Predicate<UserBook> predicate)
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserBook> UpdateUserBookAsync(UserBook userBook)
    {
        throw new NotImplementedException();
    }
}
