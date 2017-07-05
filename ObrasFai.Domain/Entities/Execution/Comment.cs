using System;
using ObrasFai.Domain.Scopes.Execution;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Execution
{
    public class Comment : EntityRegistered
    {
        protected Comment() { }
        public Comment(
            int constructionId,
            Int16 natureId,
            DateTime date,
            string text,
            int userIdRegistration)
        {
            ConstructionId = constructionId;
            NatureId = natureId;
            Date = date;
            Text = text;
            DateOfGeneration = DateTime.Now;
            UserIdRegistered = userIdRegistration;
        }

        public Int16 Id { get; set; }
        public int ConstructionId { get; set; }
        public Int16 NatureId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public void Create()
        {
            if (!this.CreateCommentScopeIsValid())
                return;
        }

        public void UpdateInfo(
            Int16 id,
            int constructionId,
            Int16 natureId,
            DateTime date,
            string text)
        {
            if (!this.UpdateInfoScopeIsValid(
                id,
                constructionId,
                natureId,
                date,
                text
            ))
                return;

            Id = id;
            ConstructionId = constructionId;
            NatureId = natureId;
            Date = date;
            Text = text;
            
        }
    }
}
