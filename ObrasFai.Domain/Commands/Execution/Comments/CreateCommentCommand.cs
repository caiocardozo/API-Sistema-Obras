using System;

namespace ObrasFai.Domain.Commands.Execution.Comments
{
    public class CreateCommentCommand
    {
        public CreateCommentCommand(
            int constructionId,
            short natureId,
            string date,
            string text,
            int userIdRegistered)
        {
            ConstructionId = constructionId;
            NatureId = natureId;
            Date = Convert.ToDateTime(date);
            Text = text;
            UserIdRegistered = userIdRegistered;
        }

        public int ConstructionId { get; set; }
        public Int16 NatureId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public int UserIdRegistered { get; set; }

    }
}
