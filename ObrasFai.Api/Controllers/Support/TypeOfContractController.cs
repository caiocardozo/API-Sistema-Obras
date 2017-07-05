using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Support.TypeOfContract;
using ObrasFai.Domain.Services.Support;

namespace ObrasFai.Api.Controllers.Support
{
    public class TypeOfContractController : BaseController
    {
        private readonly ITypeOfContractApplicationService _service;

        public TypeOfContractController(ITypeOfContractApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/typeofcontract")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var typeOfContract = _service.Get();
            return CreateResponse(HttpStatusCode.OK, typeOfContract);
        }

        [HttpGet]
        [Route("api/v1/typeofcontract/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var typeOfContract = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, typeOfContract);
        }

        [HttpPost]
        [Route("api/v1/typeofcontract")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateTypeOfContractCommand(
                description: (string)body.description,
                integratedSapiens: (string)body.integratedSapiens,
                serviceTransaction: (string)body.serviceTransaction,
                userIdRegistered: (int)body.userIdRegistered
            );

            var typeOfContract = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, typeOfContract);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/typeofcontract/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditTypeOfContractCommand(
                id: id,
                description: (string)body.description,
                integratedSapiens: (string)body.integratedSapiens,
                serviceTransaction: (string)body.serviceTransaction,
                status: (string)body.status
            );

            var typeOfContract = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, typeOfContract);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/typeofcontract/status/{id}")]
        public Task<HttpResponseMessage> UpdateStatus(int id, [FromBody]dynamic body)
        {
            var command = new UpdateStatusTOContractCommand(
                id: id
             );

            var typeOfContract = _service.UpdateStatus(command);
            return CreateResponse(HttpStatusCode.OK, typeOfContract);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/typeofcontract/integratedsapiens/{id}")]
        public Task<HttpResponseMessage> UpdateIntegratedSapiens(int id, [FromBody]dynamic body)
        {
            var command = new UpdateISapiensTOContractCommand(
                id: id
             );

            var typeOfContract = _service.UpdateISapiens(command);
            return CreateResponse(HttpStatusCode.OK, typeOfContract);
        }


        [HttpDelete]
        //[Authorize]
        [Route("api/v1/typeofcontract/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var typeOfContract = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, typeOfContract);
        }

       
    }
}