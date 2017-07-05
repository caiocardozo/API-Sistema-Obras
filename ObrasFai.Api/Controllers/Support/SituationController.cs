using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Support.Situation;
using ObrasFai.Domain.Services.Support;

namespace ObrasFai.Api.Controllers.Support
{
    public class SituationController : BaseController
    {
        private readonly ISituationApplicationService _service;

        public SituationController(ISituationApplicationService service)
        {
            this._service = service;
        }
        /// <summary>
        /// Obter todos os produtos 
        /// </summary>
        /// <remarks>
        /// Obtem a lista de todos os produtos
        /// </remarks>
        /// <returns></returns>
        /// <response code ="200"></response>
        [HttpGet]
        [Route("api/v1/situation")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var situation = _service.Get();
            return CreateResponse(HttpStatusCode.OK, situation);
        }

        [HttpGet]
        [Route("api/v1/situation/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var situation = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, situation);
        }

        [HttpPost]
        [Route("api/v1/situation")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateSituationCommand(
                description: (string)body.description,
                userIdRegistered:(int)body.userIdRegistered
            );

            var situation = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, situation);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/situation/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditSituationCommand(
                id: id,
                description: (string)body.description,
                status: (string)body.status
            );

            var situation = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, situation);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/situation/status/{id}")]
        public Task<HttpResponseMessage> UpdateStatus(int id, [FromBody]dynamic body)
        {
            var command = new UpdateStatusSituationCommand(
                id: id
             );

            var situation = _service.UpdateStatus(command);
            return CreateResponse(HttpStatusCode.OK, situation);
        }


        [HttpDelete]
        //[Authorize]
        [Route("api/v1/situation/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var situation = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, situation);
        }
    }

}