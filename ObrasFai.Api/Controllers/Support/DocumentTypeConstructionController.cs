using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Support.DocumentType;
using ObrasFai.Domain.Services.Support;

namespace ObrasFai.Api.Controllers.Support
{
    public class DocumentTypeConstructionController : BaseController
    {
        private readonly IDocumentTypeConstructionApplicationService _service;

        public DocumentTypeConstructionController(IDocumentTypeConstructionApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/documenttypeconstruction")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var documenttconstruction = _service.Get();
            return CreateResponse(HttpStatusCode.OK, documenttconstruction);
        }

        [HttpGet]
        [Route("api/v1/documenttypeconstruction/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var documenttconstruction = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, documenttconstruction);
        }

        [HttpPost]
        [Route("api/v1/documenttypeconstruction")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateDocumentTypeConstructionCommand(
                description: (string)body.description,
                userIdRegistered: (int)body.userIdRegistered
            );

            var documenttconstruction = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, documenttconstruction);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/documenttypeconstruction/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditDocumentTypeConstructionCommand(
                id: id,
                description: (string)body.description,
                status: (string)body.status
            );

            var documenttconstruction = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, documenttconstruction);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/documenttypeconstruction/status/{id}")]
        public Task<HttpResponseMessage> UpdateStatus(int id, [FromBody]dynamic body)
        {
            var command = new UpdateStatusDocumentTypeConstructionCommand(
                id: id
             );

            var documenttconstruction = _service.UpdateStatus(command);
            return CreateResponse(HttpStatusCode.OK, documenttconstruction);
        }


        [HttpDelete]
        //[Authorize]
        [Route("api/v1/documenttypeconstruction/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var documenttconstruction = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, documenttconstruction);
        }
    }
}