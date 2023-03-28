using Jadeed.Domain.Entities;

namespace Jadeed.Data.IRepositories;

public interface IUserBookRepository
{
    ValueTask<UserBook> InsertUserBookAsync(UserBook userBook);
    ValueTask<UserBook> UpdateUserBookAsync(UserBook userBook,long id);
    ValueTask<bool> DeleteUserBookAsync(long id);
    ValueTask<UserBook> SelectUserBookAsync(Predicate<UserBook> predicate);
    IQueryable<UserBook> SelectAllUserBookAsync();
}
