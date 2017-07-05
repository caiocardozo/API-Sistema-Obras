using System.Collections.Generic;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Repositories.Support
{
    public interface ITypeOfBondRepository
    {
        List<TypeOfBond> Get();
        List<TypeOfBond> Get(int skip, int take);
        TypeOfBond Get(int id);
        void Create(TypeOfBond typeOfBond);
        void Update(TypeOfBond typeOfBond);
        void Delete(TypeOfBond typeOfBond);
    }
}
