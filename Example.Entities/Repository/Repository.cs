using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Example.Entities.Repository
{
        /// <summary>
        /// Generic repository implementation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Repository<T> : IRepository<T> where T : class
        {
            private readonly ExampleDbContext _dbContext;
            private readonly DbSet<T> dbSet;

            /// <summary>
            /// ctor.
            /// </summary>
            /// <param name="dbContext"></param>
            public Repository(ExampleDbContext dbContext)
            {
                _dbContext = dbContext;
                dbSet = _dbContext.Set<T>();
            }

            /// <summary>
            /// Create
            /// </summary>
            /// <param name="entity"></param>
            /// <returns></returns>
            public T Create(T entity)
            {
                dbSet.Add(entity);
                return entity;
            }
            public async Task<T> CreateAsync(T entity)
            {
                await dbSet.AddAsync(entity);
                return entity;
            }

            /// <summary>
            /// Delete
            /// </summary>
            /// <param name="entity"></param>
            public void Delete(T entity)
            {
                dbSet.Remove(entity);
            }

            /// <summary>
            /// Find
            /// </summary>
            /// <param name="predicate"></param>
            /// <returns></returns>
            public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
            {
                if (predicate.Parameters.Any(x => x.Name != "f"))
                {
                    return dbSet.Where(predicate);
                }
                else
                {
                    return dbSet.AsQueryable<T>();
                }
            }

            /// <summary>
            /// GetAll
            /// </summary>
            /// <returns></returns>
            public IQueryable<T> GetAll()
            {
                return dbSet.AsQueryable<T>();
            }

            /// <summary>
            /// GetAll
            /// </summary>
            /// <typeparam name="TKey"></typeparam>
            /// <param name="keySelector"></param>
            /// <param name="pageNumber"></param>
            /// <param name="pageSize"></param>
            /// <param name="orderType"></param>
            /// <returns></returns>
            public IQueryable<T> GetAll<TKey>(Expression<Func<T, TKey>> keySelector, int pageNumber, int pageSize, string orderType = "ASC")
            {
                if (orderType == "DESC")
                    return dbSet.AsQueryable<T>().OrderByDescending(keySelector).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                else
                    return dbSet.AsQueryable<T>().OrderBy(keySelector).Skip((pageNumber - 1) * pageSize).Take(pageSize);
            }

            /// <summary>
            /// FindBy
            /// </summary>
            /// <typeparam name="TKey"></typeparam>
            /// <param name="predicate"></param>
            /// <param name="pageNumber"></param>
            /// <param name="pageSize"></param>
            /// <param name="keySelector"></param>
            /// <returns></returns>
            public IQueryable<T> FindBy<TKey>(Expression<Func<T, bool>> predicate, int pageNumber, int pageSize, Expression<Func<T, TKey>> keySelector)
            {
                var result = dbSet.Where(predicate).OrderBy(keySelector).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                return result;
            }

            /// <summary>
            /// Save
            /// </summary>
            public void Save()
            {
                _dbContext.SaveChanges();
            }
            public async Task SaveAsync()
            {
                await _dbContext.SaveChangesAsync();
            }

            /// <summary>
            /// Update
            /// </summary>
            /// <param name="entity"></param>
            public void Update(T entity)
            {
                dbSet.Update(entity);
            }

            /// <summary>
            /// DeleteRange
            /// </summary>
            /// <param name="entities"></param>
            public void DeleteRange(IEnumerable<T> entities)
            {
                dbSet.RemoveRange(entities);
            }

            /// <summary>
            /// UpdateRange
            /// </summary>
            /// <param name="entities"></param>
            public void UpdateRange(IEnumerable<T> entities)
            {
                dbSet.UpdateRange(entities);
            }

            public void CreateRange(IEnumerable<T> entities)
            {
                dbSet.AddRange(entities);
            }

        }
    }

