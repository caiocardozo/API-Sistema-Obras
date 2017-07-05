using ObrasFai.Domain.Entities.Support;
using System.Collections.Generic;
using ObrasFai.Domain.Commands.Support.Situation;

namespace ObrasFai.Domain.Services.Support
{
    public interface ISituationApplicationService
    {
        List<Situation> Get();
        List<Situation> Get(int skip, int take);
        Situation Get(int id);
        Situation Create(CreateSituationCommand command);
        Situation Update(EditSituationCommand command);
        Situation Delete(int id);
        Situation UpdateStatus(UpdateStatusSituationCommand command);

    }
}
