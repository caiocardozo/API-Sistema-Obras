using System;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Shared.Validation;

namespace ObrasFai.Domain.Scopes.Execution
{
    public static class CommentScopes
    {
        public static bool CreateCommentScopeIsValid(this Comment comment)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                 AssertionConcern.AssertIsGreaterThan(comment.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }

        public static bool UpdateInfoScopeIsValid(this Comment comment,
            Int16 id,
            int constructionId,
            Int16 natureId,
            DateTime date,
            string text
            )
        {

            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertIsGreaterThan(comment.ConstructionId, 0, "O código da obra não pode ser nulo;")
            );
        }
    }
}
