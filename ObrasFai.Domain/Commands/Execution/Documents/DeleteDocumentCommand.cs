using System;

namespace ObrasFai.Domain.Commands.Execution.Documents
{
    public class DeleteDocumentCommand
    {
        public DeleteDocumentCommand(Int16 id)
        {
            Id = id;
        }

        public Int16 Id { get; set; }
    }
}
