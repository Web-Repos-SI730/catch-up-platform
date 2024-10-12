namespace CatchUpPlatform.API.News.Shared.Domain.Model.Commands;

public record CreateFavoriteSourceCommand(string NewsApiKey, string SourceId);