using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HolisticusAPI2.Desconto.Infra.SQLServer.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> Query(Expression<Func<TEntity, bool>> query);
        IEnumerable<TEntity> ListAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);
        bool Exist(Expression<Func<TEntity, bool>> query);
        void SaveChanges();
        void Dispose();
    }
}
