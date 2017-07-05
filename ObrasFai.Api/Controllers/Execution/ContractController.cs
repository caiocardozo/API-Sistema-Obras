using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Execution.Contract;
using ObrasFai.Domain.Services.Execution;

namespace ObrasFai.Api.Controllers.Execution
{
    public class ContractController : BaseController
    {
        private readonly IContractApplicationService _service;

        public ContractController(IContractApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/contract")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var contract = _service.Get();
            return CreateResponse(HttpStatusCode.OK, contract);
        }

        [HttpGet]
        [Route("api/v1/contract/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var contract = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, contract);
        }

        [HttpPost]
        [Route("api/v1/contract")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            if (String.IsNullOrEmpty((string)body.comments))
                body.comments = " ";
            var command = new CreateContractCommand(
                constructionId: (int) body.constructionId,
                typeOfContractId: (Int16) body.typeOfContractId,
                biddingId: (int)body.biddingId,
                vendorCode: (int) body.vendorCode,
                signatureDate: (DateTime)body.signatureDate,
                contractValue: (decimal)body.contractValue,
                deadline: (Int16)body.deadline,
                area: (double)body.area,
                contractDuration: (DateTime)body.signatureDate,
                comments: (string) body.comments,
                contractOrigin:(int) body.contractOrigin,
                userIdRegistered: (int)body.userIdRegistered
            );

            var contract = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, contract);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/contract/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditContractCommand(
                id: (Int16) body.id,
                constructionId: (int) body.constructionId,
                typeOfContractId: (Int16) body.typeOfContractId,
                biddingId: (int) body.biddingId,
                vendorCode:(int)body.vendorCode,
                signatureDate: (string)body.signatureDate,
                contractValue: (decimal)body.contractValue,
                deadline: (Int16)body.deadline,
                area: (double)body.area,
                contractDuration: (string)body.contractDuration,
                comments: (string)body.comments,
               contractOrigin:(int) body.contractOrigin,
                userIdUpdated: (int)body.userIdUpdated
            );

            var contract = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, contract);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/v1/contract/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var contract = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, contract);
        }

        [HttpGet]
        [Route("api/v1/contractconstruction/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> GetContractsConstruction(int id)
        {
            var bidding = _service.GetContractsConstruction(id);
            return CreateResponse(HttpStatusCode.OK, bidding);
        }

    }
}