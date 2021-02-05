using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSigtAPI.Models;
using TestSigtAPI.Repository.Interfaces;
using TestSigtAPI.Services.Service;

namespace TestSigtAPI.Services
{
    public class ExperienceService : IExperienceService
    {
        private readonly IExperienceRepository _repository;

        public ExperienceService(IExperienceRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Experience> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<Experience> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Save(Experience entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var oldEntity = await GetById(entity.Id);

            if (oldEntity == null)
                await _repository.Insert(entity);
            else
                await _repository.Update(oldEntity, entity);
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await _repository.Delete(entity);
        }
    }
}

