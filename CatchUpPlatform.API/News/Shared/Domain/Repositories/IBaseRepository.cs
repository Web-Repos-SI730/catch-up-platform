namespace CatchUpPlatform.API.News.Shared.Domain.Repositories;

public interface IBaseRepository<TEntity>
{
    Task AddSync(TEntity entity);
    Task<TEntity?> FindByIdSync(int id);
    void Update(TEntity entity);
    void Remove(TEntity entity);
    Task<IEnumerable<TEntity>> ListAsync();
}