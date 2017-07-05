using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Administration;
using ObrasFai.Domain.Repositories.Administration;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Administration
{
    public class PersonRepository : IPersonRepository
    {
        private ObrasFaiDataContext _context;

        public PersonRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }
        public void Create(Person person)
        {
            _context.People.Add(person);
        }

        public void Delete(Person person)
        {
            _context.People.Remove(person);
        }

        public List<Person> Get()
        {
            return _context.People.ToList();
        }

        public Person Get(int id)
        {
            return _context.People.Find(id);
        }

        public List<Person> Get(int skip, int take)
        {
            return _context.People.OrderBy(x => x.Name).Skip(skip).Take(take).ToList();
        }

        public void Update(Person person)
        {
            _context.Entry<Person>(person).State = EntityState.Modified;
        }
    }
}
