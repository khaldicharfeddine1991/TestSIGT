using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSigtAPI.Models;

namespace TestSigtAPI.Services.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        Task<User> GetById(int id);
        Task Save(User entity);
        Task Delete(int id);
    }
}
