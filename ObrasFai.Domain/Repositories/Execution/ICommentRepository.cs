using System.Collections.Generic;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Domain.Repositories.Execution
{
    public interface ICommentRepository
    {
        List<Comment> Get();
        List<Comment> Get(int skip, int take);
        Comment Get(int id);
        void Create(Comment comments);
        void Update(Comment comments);
        void Delete(Comment comments);
    }
}
