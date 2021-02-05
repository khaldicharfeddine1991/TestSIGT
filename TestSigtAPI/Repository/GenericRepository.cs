using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TestSigtAPI.Models;
using TestSigtAPI.Models.Context;
using TestSigtAPI.Repository.Interfaces;

namespace TestSigtAPI.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly MyDBContext DbContext;

        public GenericRepository(MyDBContext context)
        {
            DbContext = context;
        }

        public IEnumerable<T> GetAll()
        {
            return DbContext.Set<T>().AsEnumerable();
        }

        public async Task<T> Get(object[] param)
        {
            return await DbContext.Set<T>().FindAsync(param);
        }

        public async Task Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await DbContext.Set<T>().AddAsync(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            DbContext.Set<T>().Update(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task Update(T oldEntity, T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var contextEntry = DbContext.Entry<T>(oldEntity);
            contextEntry.State = EntityState.Detached;
            DbContext.Attach(entity);

            DbContext.Set<T>().Update(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            DbContext.Set<T>().Remove(entity);
            await DbContext.SaveChangesAsync();
        }
    }
}

