using System;

namespace ObrasFai.Domain.Commands.Execution.Documents
{
    public class EditDocumentCommand
    {
        public EditDocumentCommand(
           Int16 id,
           int constructionId,
           Int16 documentTypeConstructionId,
           string date,
           string number,
           string comments)
        {
            Id = id;
            ConstructionId = constructionId;
            DocumentTypeConstructionId = documentTypeConstructionId;
            Date = Convert.ToDateTime(date);
            Number = number;
            Comments = comments;
 
        }

        public Int16 Id { get; set; }
        public int ConstructionId { get; set; }
        public Int16 DocumentTypeConstructionId { get; set; }
        public DateTime Date { get; set; }
        public string Number { get; set; }
        public string Comments { get; set; }
    }
}
