using Jadeed.Domain.Entities;

namespace Jadeed.Data.IRepositories;

public interface IUserBookRepository
{
    ValueTask<UserBook> InsertUserBookAsync(UserBook userBook);
    ValueTask<UserBook> UpdateUserBookAsync(UserBook userBook);
    ValueTask<bool> DeleteUserBookAsync(long id);
    ValueTask<UserBook> SelectUserBookAsync(Predicate<UserBook> predicate);
    ValueTask<List<UserBook>> SelectAllUserBookAsync();
}
