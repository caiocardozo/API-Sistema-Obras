using System.Collections.Generic;
using ObrasFai.Domain.Commands.Administration.Person;
using ObrasFai.Domain.Entities.Administration;

namespace ObrasFai.Domain.Services.Administration
{
    public interface IPersonApplicationService
    {
        List<Person> Get();
        List<Person> Get(int skip, int take);
        Person Get(int id);
        Person Create(CreatePersonCommand command);
        Person Update(EditPersonCommand command);
        Person Delete(int id);
      }
}
