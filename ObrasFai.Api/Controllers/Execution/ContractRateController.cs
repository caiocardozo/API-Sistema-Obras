using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Execution.ContractRate;
using ObrasFai.Domain.Services.Execution;

namespace ObrasFai.Api.Controllers.Execution
{
    public class ContractRateController : BaseController
    {
        private readonly IContractRateApplicationService _service;

        public ContractRateController(IContractRateApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/contractrate")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var contractRate = _service.Get();
            return CreateResponse(HttpStatusCode.OK, contractRate);
        }

        [HttpGet]
        [Route("api/v1/contractrate/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var contractRate = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, contractRate);
        }

        [HttpPost]
        [Route("api/v1/contractapp")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateContractRateCommand(
                contractId: (int)body.contractId,
                constructionId: (int)body.constructionId,
                typeOfContractId: (Int16)body.typeOfContractId,
                companyCode: (Int16)body.companyCode,
                affiliateCode: (Int16)body.affiliateCode,
                itemSequence: (Int16)body.itemSequence,
                serviceCode: (string)body.serviceCode,
                apportionmentValue: (decimal)body.apportionmentValue,
                projectNumber: (int)body.projectNumber,
                projectPhaseCode: (int)body.projectPhaseCode,
                financialAccountCode: (int)body.financialAccountCode,
                costCenterCode: (int)body.costCenterCode,
                userIdRegistered: (int) body.userIdRegistered
            );

            var contractRate = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, contractRate);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/contractrate/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditContractRateCommand(
                id: (int)body.id,
                contractId: (int)body.contractId,
                constructionId: (int)body.constructionId,
                typeOfContractId: (Int16)body.typeOfContractId,
                companyCode: (Int16)body.companyCode,
                affiliateCode: (Int16)body.affiliateCode,
                purchaseOrderNumber: (int)body.purchaseOrderNumber,
                serviceTransactionCode: (string)body.serviceTransactionCode,
                dateOfIssue: (string)body.dateOfIssue,
                userCode: (int)body.userCode,
                vendorCode: (int)body.vendorCode,
                paymentConditionCode: (string)body.paymentConditionCode,
                itemSequence: (Int16)body.itemSequence,
                serviceCode: (string)body.serviceCode,
                apportionmentValue: (int)body.apportionmentValue,
                projectNumber: (int)body.projectNumber,
                projectPhaseCode: (int)body.projectPhaseCode,
                financialAccountCode: (int)body.financialAccountCode,
                costCenterCode: (int)body.costCenterCode,
                purchaseOrderOrigin: (int)body.purchaseOrderOrigin,
                userIdUpdated: (int)body.userIdUpdated
            );

            var contractRate = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, contractRate);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/v1/contractrate/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var contractRate = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, contractRate);
        }

    }
}