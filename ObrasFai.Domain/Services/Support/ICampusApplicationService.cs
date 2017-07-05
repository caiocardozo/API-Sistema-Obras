using ObrasFai.Domain.Commands.Support.Campus;
using ObrasFai.Domain.Entities.Support;
using System;
using System.Collections.Generic;

namespace ObrasFai.Domain.Services.Support
{
    public interface ICampusApplicationService
    {
        List<Campus> Get();
        List<Campus> Get(int skip, int take);
        Campus Get(Int16 id);
        Campus Create(CreateCampusCommand command);
        Campus Update(EditCampusCommand command);
        Campus Delete(Int16 id);
       
    }
}
