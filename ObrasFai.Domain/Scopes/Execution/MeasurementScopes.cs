using System;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Execution
{
    public static class MeasurementScopes
    {
        public static bool CreateMeasurementScopeIsValid(this Measurement measurement)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                 AssertionConcern.AssertIsGreaterThan(measurement.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }

        public static bool UpdateInfoScopeIsValid(this Measurement measurement,
            int id,
            int constructionId,
            int contractId,
            Int16 supervisorId,
            DateTime date,
            decimal value,
            string comments,
            int apportionmentCode,
            int chit,
            string chitSeries)
        {

            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(measurement.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }
    }
}
