using System.Linq.Expressions;

namespace IusNatura.Cal.Application.Interfaces
{
    public interface IBaseService<TEntity> : IDisposable where TEntity : class
    {
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(int id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}