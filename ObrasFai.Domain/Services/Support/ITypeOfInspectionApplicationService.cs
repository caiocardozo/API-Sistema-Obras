using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.TypeOfInspection;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Services.Support
{
    public interface ITypeOfInspectionApplicationService
    {
        List<TypeOfInspection> Get();
        List<TypeOfInspection> Get(int skip, int take);
        TypeOfInspection Get(int id);
        TypeOfInspection Create(CreateTypeOfInspectionCommand command);
        TypeOfInspection Update(EditTypeOfInspectionCommand command);
        TypeOfInspection Delete(int id);
        TypeOfInspection UpdateStatus(UpdateStatusTOInspectionCommand command);
    }
}
