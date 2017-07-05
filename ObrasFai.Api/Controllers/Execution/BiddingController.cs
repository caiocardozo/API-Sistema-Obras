using ObrasFai.Domain.Commands.Execution.Bidding;
using ObrasFai.Domain.Services.Execution;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ObrasFai.Api.Controllers.Execution
{
    public class BiddingController : BaseController
    {
        private readonly IBiddingApplicationService _service;

        public BiddingController(IBiddingApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/bidding")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var bidding = _service.Get();
            return CreateResponse(HttpStatusCode.OK, bidding);
        }

        [HttpGet]
        [Route("api/v1/bidding/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var bidding = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, bidding);
        }

        [HttpPost]
        [Route("api/v1/bidding")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateBiddingCommand(
            constructionId: (int)body.constructionId,
            biddingShoppingPortalId: (int)body.biddingShoppingPortalId,
            amount: (decimal)body.amount,
            executionTime: (Int16)body.executionTime
            );

            var bidding = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, bidding);
        }
        
        [HttpPut]
        //[Authorize]
        [Route("api/v1/bidding/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditBiddingCommand(
                id: (Int16)body.id,
                constructionId: (int)body.constructionId,
                biddingShoppingPortalId: (int)body.biddingShoppingPortalId,
                amount: (decimal)body.amount,
                executionTime: (Int16)body.executionTime
            );
            var bidding = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, bidding);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/v1/bidding/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var bidding = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, bidding);
        }


        [HttpGet]
        [Route("api/v1/biddingconstruction/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> GetBiddingConstruction(int id)
        {
            var bidding = _service.GetBiddingsConstruction(id);
            return CreateResponse(HttpStatusCode.OK, bidding);
        }
    }
}