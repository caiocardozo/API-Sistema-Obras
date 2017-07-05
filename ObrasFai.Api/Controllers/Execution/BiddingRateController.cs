using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Execution.BiddingRate;
using ObrasFai.Domain.Services.Execution;

namespace ObrasFai.Api.Controllers.Execution
{
    public class BiddingRateController : BaseController
    {
        private readonly IBiddingRateApplicationService _service;

        public BiddingRateController(IBiddingRateApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/biddingapp")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var biddingRate = _service.Get();
            return CreateResponse(HttpStatusCode.OK, biddingRate);
        }

        [HttpGet]
        [Route("api/v1/biddingapp/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var biddingRate = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, biddingRate);
        }

        [HttpPost]
        [Route("api/v1/biddingapp")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateBiddingRateCommand(
                biddingId: (int)body.biddingId,
                constructionId: (int)body.constructionId,
                biddingShoppingPortalId: (Int16)body.biddingShoppingPortalId,
                itemSequence: (Int16)body.itemSequence,
                serviceCode: (string)body.serviceCode,
                apportionmentValue: (decimal)body.apportionmentValue,
                projectNumber: (int)body.projectNumber,
                projectPhaseCode: (int)body.projectPhaseCode,
                financialAccountCode: (int)body.financialAccountCode,
                costCenterCode: (int)body.costCenterCode,
                userIdRegistered: (int) body.userIdRegistered
            );

            var biddingRate = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, biddingRate);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/biddingapp/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditBiddingRateCommand(
                id: (int)body.id,
                biddingId: (int)body.biddingId,
                constructionId: (int)body.constructionId,
                biddingShoppingPortalId: (Int16)body.biddingShoppingPortalId,
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
                userIdUpdated: (int)body.userIdUpdated
            );
            var biddingRate = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, biddingRate);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/v1/biddingapp/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var biddingRate = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, biddingRate);
        }

        [HttpGet]
        //[Route("api/products/{skip:int:min(0)}/{take:int:min(1)}")]
        [Route("api/v1/biddingappconstruction/{idbidding}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> GetBAConstruction(int idbidding)
        {
            var biddingapportionment = _service.GetBAConstruction(idbidding);
            return CreateResponse(HttpStatusCode.OK, biddingapportionment);
        }
    }
}