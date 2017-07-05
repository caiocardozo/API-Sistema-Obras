using System.Collections.Generic;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Repositories.Execution
{
   public interface IMeasurementRepository
    {
        List<Measurement> Get();
        List<Measurement> Get(int skip, int take);
        Measurement Get(int id);
        void Create(Measurement measurement);
        void Update(Measurement measurement);
        void Delete(Measurement measurement);

        //Return all measurements of a constructions
        List<Measurement> GetMeasurementsConstruction(int idConstruction);
   }
}
