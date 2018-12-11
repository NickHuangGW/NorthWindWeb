using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using NorthWindPracticeWeb.Repository.Interfaces;

namespace NorthWindPracticeWeb.Repository
{
    /// <summary>
    /// GenericRepository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="NorthWindPracticeWeb.Repository.Interfaces.IGenericRepository{T}" />
    public class GenericRepository<T>: IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Gets or sets the unit of work.
        /// </summary>
        /// <value>
        /// The unit of work.
        /// </value>
        public IUnitOfWork UnitOfWork { get; set; }
        /// <summary>
        /// Gets or sets the ef database set.
        /// </summary>
        /// <value>
        /// The ef database set.
        /// </value>
        private DbSet<T> EfDbSet { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{T}"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        public GenericRepository(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            EfDbSet = UnitOfWork.UnitDbContext.Set<T>();
        }
        /// <summary>
        /// Creates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        public void Create(T model)
        {
            EfDbSet.Add(model);
        }
        /// <summary>
        /// Deletes the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        public void Delete(T model)
        {
            EfDbSet.Remove(model);
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return EfDbSet.AsQueryable();
        }
        /// <summary>
        /// Queries the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return EfDbSet.Where(predicate);
        }
    }
}