using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Measurement;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Services.Execution
{
    public interface IMeasurementApplicationService
    {
        List<Measurement> Get();
        List<Measurement> Get(int skip, int take);
        Measurement Get(int id);
        Measurement Create(CreateMeasurementCommand command);
        Measurement Update(EditMeasurementCommand command);
        Measurement Delete(int id);

        //Return all measurements of a constructions
        List<Measurement> GetMeasurementsConstruction(int idConstruction);
    }
}
