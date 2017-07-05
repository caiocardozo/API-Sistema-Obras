using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.TypeOfContract;
using ObrasFai.Domain.Entities.Support;

namespace ObrasFai.Domain.Services.Support
{
    public interface ITypeOfContractApplicationService
    {
        List<TypeOfContract> Get();
        List<TypeOfContract> Get(int skip, int take);
        TypeOfContract Get(int id);
        TypeOfContract Create(CreateTypeOfContractCommand command);
        TypeOfContract Update(EditTypeOfContractCommand command);
        TypeOfContract Delete(int id);
        TypeOfContract UpdateStatus(UpdateStatusTOContractCommand command);
        TypeOfContract UpdateISapiens(UpdateISapiensTOContractCommand command);

    }
}
