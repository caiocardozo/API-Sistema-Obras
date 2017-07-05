using ObrasFai.Domain.Entities.Support;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Infra.Persistence.DataContexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace ObrasFai.Infra.Repositories.Support
{
    public class CampusRepository : ICampusRepository
    {
        private ObrasFaiDataContext _context;

        public CampusRepository(ObrasFaiDataContext context)
        {
            this._context = context;
        }

        public void Create(Campus campus)
        {
            _context.Campi.Add(campus);
        }

        public void Delete(Campus campus)
        {
            _context.Campi.Remove(campus);
        }

        public List<Campus> Get()
        {
            return _context.Campi.OrderBy(s => s.Id).ToList();
        }

        public Campus Get(Int16 id)
        {
            return _context.Campi.Find(id);
        }

        public List<Campus> Get(int skip, int take)
        {
            return _context.Campi.OrderBy(x => x.City).Skip(skip).Take(take).ToList();
        }

        public void Update(Campus campus)
        {
            _context.Entry<Campus>(campus).State = EntityState.Modified;
        }
    }
}