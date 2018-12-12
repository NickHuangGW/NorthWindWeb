using System.Data.Entity;
using NorthWindPracticeWeb.Repository.Interfaces;
using NorthWindPracticeWeb.Repository.Models;

namespace NorthWindPracticeWeb.Repository
{
    /// <summary>
    /// UnitOfWork
    /// </summary>
    /// <seealso cref="NorthWindPracticeWeb.Repository.Interfaces.IUnitOfWork" />
    public class UnitOfWork: IUnitOfWork
    {
        /// <summary>
        /// Gets or sets the unit database context.
        /// </summary>
        /// <value>
        /// The unit database context.
        /// </value>
        public DbContext UnitDbContext { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        public UnitOfWork(DbContext dbContext)
        {
            UnitDbContext = dbContext;
        }
        /// <summary>
        /// Commits the trans.
        /// </summary>
        public void CommitTrans()
        {
            UnitDbContext.SaveChanges();
        }
    }
}