using Bllueprint.Core.Domain;

namespace Bllueprint.Core.Application;

public interface IRepository<TEntity>
where TEntity : class, IAggregate
{
    Task<TEntity> AddAsync(TEntity entity);

    Task<bool> DeleteAsync(TEntity entity);

    Task<TEntity?> GetByIdAsync(Guid id);

    Task<TEntity> UpdateAsync(TEntity entity);
}
