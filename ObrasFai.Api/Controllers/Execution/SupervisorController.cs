using ObrasFai.Domain.Commands.Execution.Supervisor;
using ObrasFai.Domain.Services.Execution;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ObrasFai.Api.Controllers.Execution
{
    public class SupervisorController : BaseController
    {
        private readonly ISupervisorApplicationService _service;

        public SupervisorController(ISupervisorApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/supervisor")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var supervisor = _service.Get();
            return CreateResponse(HttpStatusCode.OK, supervisor);
        }

        [HttpGet]
        [Route("api/v1/supervisor/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var supervisor = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, supervisor);
        }

        [HttpPost]
        [Route("api/v1/supervisor")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateSupervisorCommand(
            name: (string)body.name,
            cpf: (Int64)body.cpf,
            email: (string)body.email,
            phone: (string)body.phone,
            phoneTwo: (string)body.phoneTwo,
            typeInspectionId: (Int16)body.typeInspectionId,
            creaNumber:(string)body.creaNumber,
            userIdRegistered: (int)body.userIdRegistered
            );

            var supervisor = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, supervisor);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/supervisor/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditSupervisorCommand(
            id: (Int16)body.id,
            name: (string)body.name,
            cpf: (Int64)body.cpf,
            email: (string)body.email,
            phone: (string)body.phone,
            phoneTwo: (string)body.phoneTwo,
            typeInspectionId: (Int16)body.typeInspectionId,
            status:(string) body.status,
            creaNumber:(string)body.creaNumber
            );

            var supervisor = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, supervisor);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/v1/supervisor/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var supervisor = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, supervisor);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/supervisor/status/{id}")]
        public Task<HttpResponseMessage> UpdateStatus(int id, [FromBody]dynamic body)
        {
            var command = new UpdateStatusSupervisorCommand(
                id: id
            );

            var supervisor = _service.UpdateStatus(command);
            return CreateResponse(HttpStatusCode.OK, supervisor);
        }
    }
}