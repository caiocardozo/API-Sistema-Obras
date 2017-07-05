using System.Collections.Generic;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Repositories.Execution
{
    public interface IBondRepository
    {
        List<Bond> Get();
        List<Bond> Get(int skip, int take);
        Bond Get(int id);
        void Create(Bond bond);
        void Update(Bond bond);
        void Delete(Bond bond);
    }
}
