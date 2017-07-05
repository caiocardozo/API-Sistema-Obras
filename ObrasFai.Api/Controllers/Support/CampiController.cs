using ObrasFai.Domain.Commands.Support.Campus;
using ObrasFai.Domain.Services.Support;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ObrasFai.Api.Controllers.Support
{
    public class CampiController : BaseController
    {
        private readonly ICampusApplicationService _service;

        public CampiController(ICampusApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/campi")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var campus = _service.Get();
            return CreateResponse(HttpStatusCode.OK, campus);
        }

        [HttpGet]
        [Route("api/v1/campi/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(Int16 id)
        {
            var campus = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, campus);
        }

        [HttpPost]
        [Route("api/v1/campi")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateCampusCommand(
                city: (string)body.city
            );

            var campus = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, campus);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/campi/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditCampusCommand(
                id: id,
                city: (string)body.city
            );

            var campus = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, campus);
        }

                [HttpDelete]
        //[Authorize]
        [Route("api/v1/campi/{id}")]
        public Task<HttpResponseMessage> Delete(Int16 id)
        {
            var campus = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, campus);
        }
    }
}