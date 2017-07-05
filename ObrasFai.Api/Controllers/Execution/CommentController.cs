using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Execution.Comments;
using ObrasFai.Domain.Services.Execution;

namespace ObrasFai.Api.Controllers.Execution
{
    public class CommentController : BaseController
    {
        private readonly ICommentApplicationService _service;

        public CommentController(ICommentApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/comment")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var comment = _service.Get();
            return CreateResponse(HttpStatusCode.OK, comment);
        }

        [HttpGet]
        [Route("api/v1/comment/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var comment = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, comment);
        }

        [HttpPost]
        [Route("api/v1/comment")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateCommentCommand(
                constructionId: (int)body.constructionId,
                natureId: (Int16)body.natureId,
                date: (string)body.date,
                text: (string)body.text,
                userIdRegistered: (int)body.userIdRegistered
            );

            var comment = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, comment);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/comment/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditCommentCommand(
                id: (Int16)body.id,
                constructionId: (int)body.constructionId,
                natureId: (Int16)body.natureId,
                date: (string)body.date,
                text: (string)body.text
            );

            var comment = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, comment);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/v1/comment/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var comment = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, comment);
        }


    }
}