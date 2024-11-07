using IusNatura.Cal.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace RocketseatCSharpDesafio02.Entities;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected AppDbContext Db;
    protected DbSet<TEntity> DbSet;

    public BaseRepository(AppDbContext context)
    {
        Db = context;
        DbSet = Db.Set<TEntity>();
    }

    public void Dispose()
    {
        Db.Dispose();
        GC.SuppressFinalize(this);
    }

    public virtual TEntity Create(TEntity entity)
    {
        return DbSet.Add(entity).Entity;
    }

    public virtual TEntity Update(TEntity entity)
    {
        var entry = Db.Entry(entity);
        DbSet.Attach(entity);
        entry.State = EntityState.Modified;
        return entity;
    }

    public virtual void Delete(int id)
    {
        var entity = DbSet.Find(id);

        if (entity != null)
            DbSet.Remove(entity);
    }

    public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
    {
        return DbSet.Where(predicate).ToList();
    }
}