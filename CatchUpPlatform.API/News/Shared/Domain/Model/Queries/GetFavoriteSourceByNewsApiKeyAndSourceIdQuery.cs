namespace CatchUpPlatform.API.News.Shared.Domain.Model.Queries;

public record GetFavoriteSourceByNewsApiKeyAndSourceIdQuery(string NewsApiKey, string SourceId);
