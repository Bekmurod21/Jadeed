using Jadeed.Data.Context;
using Jadeed.Data.IRepositories;
using Jadeed.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jadeed.Data.Repositories;

public class LibraryRepository : ILibraryRepository
{
    AppDbContext appDbContext = new AppDbContext();
    public async ValueTask<bool> DeleteLibraryAsync(long id)
    {
        var entity = await appDbContext.Libraries.FirstOrDefaultAsync(library =>library.Id.Equals(id));
        if (entity is null)
            return false;
        appDbContext.Libraries.Remove(entity);
        await appDbContext.SaveChangesAsync();
        return true;
    }

    public async ValueTask<Library> InsertLibraryAsync(Library library)
    {
        var entity = await appDbContext.Libraries.AddAsync(library);
        await appDbContext.SaveChangesAsync();
        return entity.Entity;
    }

    public IQueryable<Library> SelectAllLibraryAsync()
    {
        var query = "select * from \"Libraries\"";
        return appDbContext.Libraries.FromSqlRaw(query);
    }

    public async ValueTask<Library> SelectLibraryAsync(Predicate<Library> predicate)
    {
        return await appDbContext.Libraries.FirstOrDefaultAsync(library => predicate(library));
    }

    public async ValueTask<Library> UpdateLibraryAsync(long id, Library library)
    {
        library.Id = id;
        var entity = appDbContext.Libraries.Update(library);
        await appDbContext.SaveChangesAsync();
        return entity.Entity;
    }
}
