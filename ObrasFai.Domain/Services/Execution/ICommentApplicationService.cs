using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Comments;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Services.Execution
{
    public interface ICommentApplicationService
    {
        List<Comment> Get();
        List<Comment> Get(int skip, int take);
        Comment Get(int id);
        Comment Create(CreateCommentCommand command);
        Comment Update(EditCommentCommand command);
        Comment Delete(int id);
    }
}
