using System.Collections.Generic;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Repositories.Support
{
    public interface ISituationRepository
    {
        List<Situation> Get();
        List<Situation> Get(int skip, int take);
        Situation Get(int id);
        void Create(Situation situation);
        void Update(Situation situation);
        void Delete(Situation situation);
    }
}
