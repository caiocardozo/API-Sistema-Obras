using System;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Execution
{
    public static class ConstructionScopes
    {
        public static bool RegisterConstructionScopeIsValid(this Construction construction)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotNull(construction.Name, "O nome da obra é obrigatória."),
                AssertionConcern.AssertNotNull(construction.Nickname, "O Apelido da obra é obrigatória."),
                AssertionConcern.AssertNotNull(construction.Description, "A descrição da obra é obrigatória."),
                AssertionConcern.AssertIsGreaterThan(construction.CampId, 0, "Código do campus nao pode ser 0."),
                AssertionConcern.AssertIsGreaterThan(construction.TypeInspectionId, 0, "Código do tipo de fiscalização nao pode ser 0."),
                AssertionConcern.AssertIsGreaterThan(construction.SituationId, 0, "Código da situação da obra nao pode ser 0."),
                AssertionConcern.AssertIsGreaterThan(construction.TypeOfConstructionId, 0, "Código do tipo de obra nao pode ser 0."),
                AssertionConcern.AssertNotNull(construction.Area, "Valor estimado é obrigatório."),
                AssertionConcern.AssertNotNull(construction.EstimatedValue, "Valor estimado é obrigatório.")
            );
        }

        public static bool UpdateInfoScopeIsValid(this Construction construction, string nickname, string description, string name, Int16 campId, Int16 typeofConstructionId, Int16 situationId,
            Int16 typeInspection, double area, decimal estimatedValue)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotNull(construction.Name, "O nome da obra é obrigatória."),
                AssertionConcern.AssertNotNull(construction.Nickname, "O Apelido da obra é obrigatória."),
                AssertionConcern.AssertNotNull(construction.Description, "A descrição da obra é obrigatória."),
                AssertionConcern.AssertIsGreaterThan(construction.CampId, 0, "Código do campus nao pode ser 0."),
                AssertionConcern.AssertIsGreaterThan(construction.TypeInspectionId, 0, "Código do tipo de fiscalização nao pode ser 0."),
                AssertionConcern.AssertIsGreaterThan(construction.SituationId, 0, "Código da situação da obra nao pode ser 0."),
                AssertionConcern.AssertIsGreaterThan(construction.TypeOfConstructionId, 0, "Código do tipo de obra nao pode ser 0."),
                AssertionConcern.AssertNotNull(construction.Area, "Valor estimado é obrigatório."),
                AssertionConcern.AssertNotNull(construction.EstimatedValue, "Valor estimado é obrigatório.")

            );
        }
    }
}
