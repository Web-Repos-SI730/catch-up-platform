using CatchUpPlatform.API.News.Domain.Repositories;
using CatchUpPlatform.API.News.Domain.Services;
using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Commands;
using CatchUpPlatform.API.Shared.Infrastructure.Persistance.EFC.Repositories;

namespace CatchUpPlatform.API.News.Application.Internal.CommandServices;

public class FavoriteSourceCommandService(IFavoriteSourceRepository favoriteSourceRepository,UnitOfWork unitOfWork)
    :IFavoriteSourceCommandService
{
    /// <inheritdoc cref="IFavoriteSourceCommandService.Handle"/>
    public async Task<FavoriteSource?> Handle(CreateFavoriteSourceCommand command)
    {
        var favoriteSource 
            = await favoriteSourceRepository.FindByNewsApiKeyAndSourceIdAsync(command.NewsApiKey, command.SourceId);
        if (favoriteSource != null) 
            throw new Exception("Favorite Source with source id already exists for this News API Key");
        favoriteSource = new FavoriteSource(command);

        try
        {
            await favoriteSourceRepository.AddSync(favoriteSource);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return favoriteSource;
    }
}