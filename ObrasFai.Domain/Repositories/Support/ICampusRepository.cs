using ObrasFai.Domain.Entities.Support;
using System;
using System.Collections.Generic;

namespace ObrasFai.Domain.Repositories.Support
{
   public interface ICampusRepository
    {
        List<Campus> Get();
        List<Campus> Get(int skip, int take);
        Campus Get(Int16 id);
        void Create(Campus campus);
        void Update(Campus campus);
        void Delete(Campus campus);
    }
}
