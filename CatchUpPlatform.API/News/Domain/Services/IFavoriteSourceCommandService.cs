using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Commands;

namespace CatchUpPlatform.API.News.Domain.Services;

// <summary>
// Favorite source command service
// </summary>

public interface IFavoriteSourceCommandService
{
    // <summary>
    // Handle create favorite source command
    // </summary>
    // <param name="command">Create favorite source command</param>
    // <returns>
    // Favorite source if successfull, otherwise null
    // </returns>
    // <see cref="CreateFavoriteSourceCommand"/>
    Task<FavoriteSource?>Handle(CreateFavoriteSourceCommand command);
}