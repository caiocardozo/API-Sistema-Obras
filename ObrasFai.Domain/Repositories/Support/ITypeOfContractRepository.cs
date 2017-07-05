using System.Collections.Generic;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Repositories.Support
{
    public interface ITypeOfContractRepository
    {
        List<TypeOfContract> Get();
        List<TypeOfContract> Get(int skip, int take);
        TypeOfContract Get(int id);
        void Create(TypeOfContract typeOfContract);
        void Update(TypeOfContract typeOfContract);
        void Delete(TypeOfContract typeOfContract);
    }
}
