using System.Collections.Generic;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Repositories.Support
{
    public interface ITypeOfConstructionRepository
    {
        List<TypeOfConstruction> Get();
        List<TypeOfConstruction> Get(int skip, int take);
        TypeOfConstruction Get(int id);
        void Create(TypeOfConstruction typeOfConstruction);
        void Update(TypeOfConstruction typeOfConstruction);
        void Delete(TypeOfConstruction typeOfConstruction);
    }
}
