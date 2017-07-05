using System.Collections.Generic;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Repositories.Support
{
    public interface ITypeOfInspectionRepository
    {
        List<TypeOfInspection> Get();
        List<TypeOfInspection> Get(int skip, int take);
        TypeOfInspection Get(int id);
        void Create(TypeOfInspection situation);
        void Update(TypeOfInspection situation);
        void Delete(TypeOfInspection situation);
    }
}
