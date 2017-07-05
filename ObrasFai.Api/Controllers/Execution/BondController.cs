using ObrasFai.Domain.Commands.Execution.Bond;
using ObrasFai.Domain.Services.Execution;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ObrasFai.Api.Controllers.Execution
{
    public class BondController : BaseController
    {
        private readonly IBondApplicationService _service;

        public BondController(IBondApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/bond")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var bond = _service.Get();
            return CreateResponse(HttpStatusCode.OK, bond);
        }

        [HttpGet]
        [Route("api/v1/bond/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var bond = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, bond);
        }

        [HttpPost]
        [Route("api/v1/bond")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateBondCommand(
             constructionId:(int) body.constructionId,
             contractId: (int)body.contractId,
             typeOfBondId: (Int16)body.typeOfBondId,
             expirationDate: (string)body.expirationDate,
             value: (decimal)body.value,
             userIdRegistered: (int)body.userIdRegistered
            );

            var bond = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, bond);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/bond/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditBondCommand(
             id: (Int16)body.id,
             constructionId: (int)body.constructionId,
             contractId: (int)body.contractId,
             typeOfBondId: (Int16)body.typeOfBondId,
             expirationDate: (string)body.expirationDate,
             value: (decimal)body.value,
             status: (string)body.status
            );

            var bond = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, bond);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/v1/bond/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var bond = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, bond);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/bond/status/{id}")]
        public Task<HttpResponseMessage> UpdateStatus(int id, [FromBody]dynamic body)
        {
            var command = new UpdateStatusBondCommand(
                id: id
             );

            var bond = _service.UpdateStatus(command);
            return CreateResponse(HttpStatusCode.OK, bond);
        }
    }
}