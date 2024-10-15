using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Shared.Domain.Repositories;

namespace CatchUpPlatform.API.News.Domain.Repositories;
/// <summary>
/// Repository for <see cref="FavoriteSource"/>
/// </summary>
public interface IFavoriteSourceRepository: IBaseRepository<FavoriteSource>
{
    /// <summary>
    /// Find all <see cref="FavoriteSource"/> by <paramref name="newsApiKey"/>
    /// </summary>
    /// <returns>
    /// A collection of <see cref="FavoriteSource"/>that matches the <paramref name="newsApiKey"/>
    /// </returns>
    Task<IEnumerable<FavoriteSource>>FindByNewsApiKeyAsync(string newsApiKey);
    /// <summary>
    /// Find <see cref="FavoriteSource"/> by <paramref name="newsApiKey"/> and <paramref name="sourceId"/>
    /// </summary>
    /// <param name="newsApiKey">The news api key</param>
    /// <param name="sourceId"> The source id</param>
    /// <returns>
    /// A collection of <see cref="FavoriteSource"/>
    /// </returns>
    /// Fijate en que solo sea un task NO METAS EL IENUMERABLE
    Task<FavoriteSource?>FindByNewsApiKeyAndSourceIdAsync(string newsApiKey, string sourceId);
    
}