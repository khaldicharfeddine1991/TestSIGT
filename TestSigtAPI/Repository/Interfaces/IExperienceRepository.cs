using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSigtAPI.Models;

namespace TestSigtAPI.Repository.Interfaces
{
    public interface IExperienceRepository : IGenericRepository<Experience>
    {
        Task<Experience> GetById(int id);

    }
}
