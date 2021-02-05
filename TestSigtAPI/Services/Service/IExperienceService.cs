using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSigtAPI.Models;

namespace TestSigtAPI.Services.Service
{
  public   interface IExperienceService
    {
        IEnumerable<Experience> GetAll();
        Task<Experience> GetById(int id);
        Task Save(Experience entity);
        Task Delete(int id);
    }
}
