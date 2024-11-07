using IusNatura.Cal.Application.Interfaces;
using NuGet.Protocol.Core.Types;
using System.Linq.Expressions;

namespace RocketseatCSharpDesafio02.Entities;

public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
{
    private readonly IBaseRepository<TEntity> _baseRepository;

    public BaseService(IBaseRepository<TEntity> baseRepository)
    {
        _baseRepository = baseRepository;
    }

    public void Dispose()
    {
        _baseRepository.Dispose();
        GC.SuppressFinalize(this);
    }

    public virtual TEntity Create(TEntity entity)
    {
        return _baseRepository.Create(entity);
    }

    public virtual TEntity Update(TEntity entity)
    {
        return _baseRepository.Update(entity);
    }

    public virtual void Delete(int id)
    {
        _baseRepository.Delete(id);
    }

    public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
    {
        return _baseRepository.Find(predicate);
    }
}