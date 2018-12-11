using System.Data.Entity;

namespace NorthWindPracticeWeb.Repository.Interfaces
{
    /// <summary>
    /// IUnitOfWork
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Gets or sets the unit database context.
        /// </summary>
        /// <value>
        /// The unit database context.
        /// </value>
        DbContext UnitDbContext { get; set; }
        /// <summary>
        /// Commits the trans.
        /// </summary>
        void CommitTrans();
    }
}