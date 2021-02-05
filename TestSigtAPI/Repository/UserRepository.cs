using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSigtAPI.Models;
using TestSigtAPI.Models.Context;
using TestSigtAPI.Repository.Interfaces;

namespace TestSigtAPI.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(MyDBContext context)
        : base(context)
        {

        }
        //public  IEnumerable<Course> GetAll()
        //{
        //    return DbContext.Set<Course>().AsEnumerable();
        //}
        public async Task<User> GetById(int id)
        {
            return await DbContext.Set<User>().FirstOrDefaultAsync(q => q.Id == id);
        }

    }
  }
