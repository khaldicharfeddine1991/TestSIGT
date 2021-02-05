using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TestSigtAPI.Models;

namespace TestSigtAPI.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<T> Get(object[] param);
        Task Insert(T entity);
        Task Update(T entity);
        Task Update(T oldEntity, T entity);
        Task Delete(T entity);
    }
}

