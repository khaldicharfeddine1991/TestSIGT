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
    public class ExperienceRepository : GenericRepository<Experience>, IExperienceRepository
    {
        public ExperienceRepository(MyDBContext context)
         : base(context)
        {

        }
        //public  IEnumerable<Course> GetAll()
        //{
        //    return DbContext.Set<Course>().AsEnumerable();
        //}
        public async Task<Experience> GetById(int id)
        {
            return await DbContext.Set<Experience>().FirstOrDefaultAsync(q => q.Id == id);
        }

    }
}
