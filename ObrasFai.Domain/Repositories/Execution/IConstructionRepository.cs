using System.Collections.Generic;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Repositories.Execution
{
    public interface IConstructionRepository
    {
        List<Construction> Get();
        List<Construction> Get(int skip, int take);
        Construction Get(int id);
        void Create(Construction construction);
        void Update(Construction construction);
        void Delete(Construction construction);
        List<Construction> GetAllListHome();
    }
}
