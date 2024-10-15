using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Repositories;
using CatchUpPlatform.API.News.Shared.Infrastructure.Persistance.EFC.Configuration;
using CatchUpPlatform.API.Shared.Infrastructure.Persistance.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CatchUpPlatform.API.News.Infrastructure.Persistence.EFC.Repository;

/// <summary>
/// Favorite source repository
/// </summary>
/// <param name="context">The <see cref="AppDbContext"/>Database Context</param>

public class FavoriteSourceRepository(AppDbContext context)
    : BaseRepository<FavoriteSource>(context), IFavoriteSourceRepository
{
   /// <inheritdoc cref="IFavoriteSourceRepository.FindByNewsApiKeyAsync"/>
    public async Task<IEnumerable<FavoriteSource>> FindByNewsApiKeyAsync(string newsApiKey)
    {
        return await Context.Set<FavoriteSource>().Where(f => f.NewsApiKey == newsApiKey).ToListAsync();
    }

    /// <inheritdoc cref="IFavoriteSourceRepository.FindByNewsApiKeyAndSourceIdAsync"/>
    public async Task<FavoriteSource?> FindByNewsApiKeyAndSourceIdAsync(string newsApiKey, string sourceId)
    {
        return await Context.Set<FavoriteSource>()
            //FIJATE QUE SEA EL ASYNC
            .FirstOrDefaultAsync(f=> f.NewsApiKey == newsApiKey && f.SourceId == sourceId);
    }


  
}