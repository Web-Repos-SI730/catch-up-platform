﻿using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Queries;
using CatchUpPlatform.API.News.Domain.Repositories;
using CatchUpPlatform.API.News.Domain.Services;
using CatchUpPlatform.API.News.Shared.Domain.Model.Queries;

namespace CatchUpPlatform.API.News.Application.Internal.QueryServices;

public class FavoriteSourceQueryService(IFavoriteSourceRepository favoriteSourceRepository):IFavoriteSourceQueryService
{
    public async Task<IEnumerable<FavoriteSource>> Handle(GetAllFavoriteSourcesByNewsApiKeyQuery query)
    {
        return await favoriteSourceRepository.FindByNewsApiKeyAsync(query.NewsApiKey);
    }

    public async Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query)
    {
        return await favoriteSourceRepository.FindByIdSync(query.Id);
    }

    public async Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query)
    {
        return await favoriteSourceRepository.FindByNewsApiKeyAndSourceIdAsync(query.NewsApiKey,query.SourceId); 
    }
}