using ObrasFai.Domain.Commands.Execution.SupervisorConstruction;
using ObrasFai.Domain.Services.Execution;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ObrasFai.Api.Controllers.Execution
{
    public class SupervisorConstructionController : BaseController
    {
        private readonly ISupervisorConstructionApplicationService _service;

        public SupervisorConstructionController(ISupervisorConstructionApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/supervisorconstruction")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var supervisorconstruction = _service.Get();
            return CreateResponse(HttpStatusCode.OK, supervisorconstruction);
        }

        [HttpGet]
        [Route("api/v1/supervisorconstruction/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var supervisorconstruction = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, supervisorconstruction);
        }

        [HttpPost]
        [Route("api/v1/supervisorconstruction")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateSupervisorConstructionCommand(
             constructionId: (int)body.constructionId,
             supervisorId: (Int16)body.supervisorId,
             userIdRegistered: (int)body.userIdRegistered
            );

            var supervisorconstruction = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, supervisorconstruction);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/supervisorconstruction/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditSupervisorConstructionCommand(
             id: (Int16)body.id,
             constructionId: (int)body.constructionId,
             supervisorId: (Int16)body.supervisorId,
             status: (string)body.status
            );

            var supervisorconstruction = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, supervisorconstruction);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/v1/supervisorconstruction/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var supervisorconstruction = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, supervisorconstruction);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/supervisorconstruction/status/{id}")]
        public Task<HttpResponseMessage> UpdateStatus(int id, [FromBody]dynamic body)
        {
            var command = new UpdateStatusSupervisorConstructionCommand(
                id: id
            );

            var supervisorconstruction = _service.UpdateStatus(command);
            return CreateResponse(HttpStatusCode.OK, supervisorconstruction);
        }
    }
}