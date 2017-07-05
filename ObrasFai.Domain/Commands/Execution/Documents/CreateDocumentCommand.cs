using System;

namespace ObrasFai.Domain.Commands.Execution.Documents
{
    public class CreateDocumentCommand
    {
        public CreateDocumentCommand(
            int constructionId, 
            Int16 documentTypeConstructionId, 
            string date, 
            string number,
            string comments, 
            int userIdRegistered)
        {
            ConstructionId = constructionId;
            DocumentTypeConstructionId = documentTypeConstructionId;
            Date = Convert.ToDateTime(date);
            Number = number;
            Comments = comments;
            UserIdRegistered = userIdRegistered;

        }

        public Int16 Id { get; set; }
        public int ConstructionId { get; set; }
        public Int16 DocumentTypeConstructionId { get; set; }
        public DateTime Date { get; set; }
        public string Number { get; set; }
        public string Comments { get; set; }
        public int UserIdRegistered { get; set; }
    }
}
