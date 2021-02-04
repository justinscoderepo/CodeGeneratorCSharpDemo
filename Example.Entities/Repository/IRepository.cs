using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Example.Entities.Repository
{
    /// <summary>
    /// Generic repository interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// GetAll
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// GetAll with filters
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderType"></param>
        /// <returns></returns>
        IQueryable<T> GetAll<TKey>(Expression<Func<T, TKey>> keySelector, int pageNumber, int pageSize, string orderType = "ASC");

        /// <summary>
        /// FindBy with query.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        IQueryable<T> FindBy<TKey>(Expression<Func<T, bool>> predicate, int pageNumber, int pageSize, Expression<Func<T, TKey>> keySelector);

        /// <summary>
        /// Find with expression.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Create(T entity);
        Task<T> CreateAsync(T entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// Save
        /// </summary>
        void Save();

        /// <summary>
        /// SaveAsync
        /// </summary>
        /// <returns></returns>
        Task SaveAsync();

        /// <summary>
        /// DeleteRange
        /// </summary>
        /// <param name="entities"></param>
        void DeleteRange(IEnumerable<T> entities);

        /// <summary>
        /// UpdateRange
        /// </summary>
        /// <param name="entities"></param>
        void UpdateRange(IEnumerable<T> entities);

        void CreateRange(IEnumerable<T> entities);
    }
}
