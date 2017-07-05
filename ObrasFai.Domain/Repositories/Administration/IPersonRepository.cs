using System.Collections.Generic;
using ObrasFai.Domain.Entities.Administration;

namespace ObrasFai.Domain.Repositories.Administration
{
    public interface IPersonRepository
    {
        List<Person> Get();
        List<Person> Get(int skip, int take);
        Person Get(int id);
        void Create(Person person);
        void Update(Person person);
        void Delete(Person person);
       }
}
