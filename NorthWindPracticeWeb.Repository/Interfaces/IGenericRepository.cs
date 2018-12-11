using System;
using System.Linq;
using System.Linq.Expressions;

namespace NorthWindPracticeWeb.Repository.Interfaces
{
    public interface IGenericRepository<T>
    {
        IUnitOfWork UnitOfWork { get; set; }

        IQueryable<T> GetAll();

        IQueryable<T> Query(Expression<Func<T, bool>> predicate);

        void Create(T model);

        void Delete(T model);
    }
}