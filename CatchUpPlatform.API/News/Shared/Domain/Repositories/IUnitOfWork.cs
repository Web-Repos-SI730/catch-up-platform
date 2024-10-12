namespace CatchUpPlatform.API.News.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}