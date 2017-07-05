using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Execution.Construction;
using ObrasFai.Domain.Services.Execution;

namespace ObrasFai.Api.Controllers.Execution
{
    public class ConstructionController : BaseController
    {
        private readonly IConstructionApplicationService _service;

        public ConstructionController(IConstructionApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/construction")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var construction = _service.Get();
            return CreateResponse(HttpStatusCode.OK, construction);
        }

        [HttpGet]
        [Route("api/v1/construction/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var construction = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, construction);
        }

        [HttpPost]
        [Route("api/v1/construction")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateConstructionCommand(
             nickname: (string)body.nickname,
             description: (string)body.description,
             name: (string)body.name,
             campId:(Int16)body.campId,
             typeofConstructionId: (Int16)body.typeOfConstructionId,
             situationId: (Int16)body.situationId,
             typeInspectionId: (Int16)body.typeInspectionId,
             startDate: (string)body.startDate,
             endDate: (string)body.endDate,
             contractTerminationDate: (string)body.contractTerminationDate,
             signatureDate: (string)body.signatureDate,
             area: (double)body.area,
             estimatedValue: (decimal)body.estimatedValue,
             userIdRegistered: (int)body.userIdRegistered
            );

            var construction = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, construction);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/construction/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditConstructionCommand(
             id: (int)body.id,
             nickname: (string)body.nickname,
             description: (string)body.description,
             name: (string)body.name,
             campId: (Int16)body.campId,
             typeofConstructionId: (Int16)body.typeofConstructionId,
             situationId: (Int16)body.situationId,
             typeInspectionId: (Int16)body.typeInspectionId,
             startDate: (string)body.startDate,
             endDate: (string)body.endDate,
             contractTerminationDate: (string)body.contractTerminationDate,
             signatureDate: (string)body.signatureDate,
             area: (double)body.area,
             estimatedValue: (decimal)body.estimatedValue,
             userIdUpdated: (int)body.userIdUpdated
            );

            var construction = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, construction);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/v1/construction/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var construction = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, construction);
        }

        [HttpGet]
        [Route("api/v1/constructionHome")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> GetAllListHome()
        {
            var construction = _service.GetAllListHome();
            return CreateResponse(HttpStatusCode.OK, construction);
        }
    }
}