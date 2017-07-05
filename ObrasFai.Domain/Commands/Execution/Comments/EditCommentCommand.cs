using System;

namespace ObrasFai.Domain.Commands.Execution.Comments
{
    public class EditCommentCommand
    {
        public EditCommentCommand(
            Int16 id,
            int constructionId,
            short natureId,
            string date,
            string text)
        {
            Id = id;
            ConstructionId = constructionId;
            NatureId = natureId;
            Date = Convert.ToDateTime(date);
            Text = text;
        }

        public Int16 Id { get; set; }
        public int ConstructionId { get; set; }
        public Int16 NatureId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
