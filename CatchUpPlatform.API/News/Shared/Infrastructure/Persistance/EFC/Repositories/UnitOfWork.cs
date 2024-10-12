using CatchUpPlatform.API.News.Shared.Domain.Repositories;
using CatchUpPlatform.API.News.Shared.Infrastructure.Persistance.EFC.Configuration;

namespace CatchUpPlatform.API.News.Shared.Infrastructure.Persistance.EFC.Repositories;

public class UnitOfWork: IUnitOfWork
{
    private readonly AppDbContext _context;
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}