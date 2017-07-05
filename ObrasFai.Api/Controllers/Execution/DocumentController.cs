using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Execution.Documents;
using ObrasFai.Domain.Services.Execution;

namespace ObrasFai.Api.Controllers.Execution
{
    public class DocumentController : BaseController
    {
        private readonly IDocumentApplicationService _service;

        public DocumentController(IDocumentApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/document")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var document = _service.Get();
            return CreateResponse(HttpStatusCode.OK, document);
        }

        [HttpGet]
        [Route("api/v1/document/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var document = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, document);
        }

        [HttpPost]
        [Route("api/v1/document")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateDocumentCommand(
                constructionId: (int)body.constructionId,
                documentTypeConstructionId: (Int16)body.documentTypeConstructionId,
                date: (string)body.date,
                number: (string)body.number,
                comments: (string)body.comments,
                userIdRegistered: (int)body.userIdRegistered
            );

            var document = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, document);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/document/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditDocumentCommand(
              id: (Int16)body.id,
              constructionId: (int)body.constructionId,
              documentTypeConstructionId: (Int16)body.documentTypeConstructionId,
              date: (string)body.date,
              number: (string)body.number,
              comments: (string)body.comments
            );

            var document = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, document);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/v1/document/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var document = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, document);
        }

    }
}