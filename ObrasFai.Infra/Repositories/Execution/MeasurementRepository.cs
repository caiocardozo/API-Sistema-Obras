using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Infra.Persistence.DataContexts;

namespace ObrasFai.Infra.Repositories.Execution
{
    public class MeasurementRepository : IMeasurementRepository
    {
        private ObrasFaiDataContext _context;

        public MeasurementRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(Measurement measurement)
        {
            _context.Measurements.Add(measurement);
        }

        public void Delete(Measurement measurement)
        {
            _context.Measurements.Remove(measurement);
        }

        public List<Measurement> Get()
        {
            return _context.Measurements.ToList();
        }

        public Measurement Get(int id)
        {
            return _context.Measurements.Find(id);
        }

        public List<Measurement> Get(int skip, int take)
        {
            return _context.Measurements.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(Measurement measurement)
        {
            _context.Entry<Measurement>(measurement).State = EntityState.Modified;
        }

        //Return all measurements of a constructions
        public List<Measurement> GetMeasurementsConstruction(int idConstruction)
        {
            return _context.Measurements.Where(m => m.ConstructionId == idConstruction).Include("Supervisor").ToList();
        }
    }
}
