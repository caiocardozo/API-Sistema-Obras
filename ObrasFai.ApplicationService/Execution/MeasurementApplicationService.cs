using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Measurement;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Domain.Services.Execution;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Execution
{
    public class MeasurementApplicationService : ApplicationService, IMeasurementApplicationService
    {
        private IMeasurementRepository _repository;

        public MeasurementApplicationService(IMeasurementRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Measurement Create(CreateMeasurementCommand command)
        {
            var measurement = new Measurement(
                command.ConstructionId,
                command.ContractId,
                command.SupervisorId,
                command.Date,
                command.Value,
                command.Comments,
                command.ApportionmentCode,
                command.Chit,
                command.ChitSeries,
                command.UserIdRegistered);
            measurement.Create();
            _repository.Create(measurement);

            if (Commit())
                return measurement;

            return null;
        }

        public Measurement Delete(int id)
        {
            var measurement = _repository.Get(id);
            _repository.Delete(measurement);

            if (Commit())
                return measurement;

            return null;
        }

        public List<Measurement> Get()
        {
            return _repository.Get();
        }

        public Measurement Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Measurement> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Measurement Update(EditMeasurementCommand command)
        {
            var measurement = _repository.Get(command.Id);
            measurement.UpdateInfo(
                command.Id,
                command.ConstructionId,
                command.ContractId,
                command.SupervisorId,
                command.Date,
                command.Value,
                command.Comments,
                command.ApportionmentCode,
                command.Chit,
                command.ChitSeries
               );
            _repository.Update(measurement);

            if (Commit())
                return measurement;

            return null;
        }

        //Return all measurements of a constructions
        public List<Measurement> GetMeasurementsConstruction(int idConstruction)
        {
            return _repository.GetMeasurementsConstruction(idConstruction);
        }
    }
}
