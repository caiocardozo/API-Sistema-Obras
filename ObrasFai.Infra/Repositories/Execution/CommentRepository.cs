using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Infra.Persistence.DataContexts;
using ObrasFai.Domain.Repositories.Execution;

namespace ObrasFai.Infra.Repositories.Execution
{
    public class CommentRepository : ICommentRepository
    {
        private ObrasFaiDataContext _context;

        public CommentRepository(ObrasFaiDataContext context)
        {
            _context = context;
        }

        public void Create(Comment comment)
        {
            _context.Comments.Add(comment);
        }

        public void Delete(Comment comment)
        {
            _context.Comments.Remove(comment);
        }

        public List<Comment> Get()
        {
            return _context.Comments.OrderBy(c => c.Id).ToList();
        }

        public Comment Get(int id)
        {
            return _context.Comments.Find(id);
        }

        public List<Comment> Get(int skip, int take)
        {
            return _context.Comments.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(Comment comment)
        {
            _context.Entry<Comment>(comment).State = EntityState.Modified;
        }
    }
}
