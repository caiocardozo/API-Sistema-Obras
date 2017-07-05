using System.Collections.Generic;
using ObrasFai.Domain.Commands.Execution.Comments;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Domain.Services.Execution;
using ObrasFai.Infra.Persistence;

namespace ObrasFai.ApplicationService.Execution
{
    public class CommentApplicationService : ApplicationService, ICommentApplicationService
    {
        private ICommentRepository _repository;

        public CommentApplicationService(ICommentRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Comment Create(CreateCommentCommand command)
        {
            var comment = new Comment(
                command.ConstructionId,
                command.NatureId,
                command.Date,
                command.Text,
                command.UserIdRegistered);
            comment.Create();
            _repository.Create(comment);

            if (Commit())
                return comment;

            return null;
        }

        public Comment Delete(int id)
        {
            var comment = _repository.Get(id);
            _repository.Delete(comment);

            if (Commit())
                return comment;

            return null;
        }

        public List<Comment> Get()
        {
            return _repository.Get();
        }

        public Comment Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Comment> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public Comment Update(EditCommentCommand command)
        {
            var comment = _repository.Get(command.Id);
            comment.UpdateInfo(
                command.Id,
                command.ConstructionId,
                command.NatureId,
                command.Date,
                command.Text
               );
            _repository.Update(comment);

            if (Commit())
                return comment;

            return null;
        }
    }
}
