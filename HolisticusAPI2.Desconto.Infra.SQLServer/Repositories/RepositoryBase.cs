using HolisticusAPI2.Desconto.Infra.SQLServer.Contexts;
using HolisticusAPI2.Desconto.Infra.SQLServer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HolisticusAPI2.Desconto.Infra.SQLServer.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SGIPDbContext _dbContext;

        public RepositoryBase(SGIPDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<TEntity> Query(Expression<Func<TEntity, bool>> query)
        {
            return _dbContext.Set<TEntity>().Where(query).AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> ListAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking().ToList();
        }

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public bool Exist(Expression<Func<TEntity, bool>> query)
        {
            return Query(query).Any();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
