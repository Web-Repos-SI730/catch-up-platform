using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Queries;
using CatchUpPlatform.API.News.Shared.Domain.Model.Queries;


namespace CatchUpPlatform.API.News.Domain.Services;

/// <summary>
/// Query service for favorite sources.
/// </summary>
public interface IFavoriteSourceQueryService
{
    /// <summary>
    ///Handle get all favorite sources by news api key query
    ///</summary>
    ///<returns>
    ///Favorite sources if successful, otherwise null
    ///</returns>
    /// <see cref="GetAllFavoriteSourcesByNewsApiKeyQuery"/>
    
    Task<IEnumerable<FavoriteSource>>Handle(GetAllFavoriteSourcesByNewsApiKeyQuery query);
    
    /// <summary>
    /// Handle get favorite source by id query
    /// </summary>
    /// <returns>
    ///<param name="query">GetFavoriteSourceByIdQuery query</param>
    /// </returns>
    /// See <see cref="GetFavoriteSourceByIdQuery"/>
    /// 
    Task<FavoriteSource?>Handle(GetFavoriteSourceByIdQuery query);

    /// <summary>
    /// Handle get favorite source by news api key and source id query
    /// </summary>
    /// <param name="query">GetFavoriteSourceByNewsApiKeyAndSourceIdQuery</param>
    /// <returns>
    /// Favorite source if successful, otherwise null
    /// </returns>
    /// See <see cref="GetFavoriteSourceByNewsApiKeyAndSourceIdQuery"/>
    /// 
    Task<FavoriteSource?>Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query);
}