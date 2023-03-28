using Jadeed.Domain.Entities;

namespace Jadeed.Data.IRepositories;

public interface ILibraryRepository
{
    ValueTask<Library> InsertLibraryAsync(Library library);
    ValueTask<Library> UpdateLibraryAsync(long id,Library library);
    ValueTask<bool> DeleteLibraryAsync(long id);
    ValueTask<Library> SelectLibraryAsync(Predicate<Library> predicate);
    IQueryable<Library> SelectAllLibraryAsync();
}
