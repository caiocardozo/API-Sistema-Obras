using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Support.NatureOfObservation;
using ObrasFai.Domain.Services.Support;

namespace ObrasFai.Api.Controllers.Support
{
    public class NatureOfObservationController : BaseController
    {
        private readonly INatureOfObservationApplicationService _service;

        public NatureOfObservationController(INatureOfObservationApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/natureofobservation")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var natureOfObservation = _service.Get();
            return CreateResponse(HttpStatusCode.OK, natureOfObservation);
        }

        [HttpGet]
        [Route("api/v1/natureofobservation/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var natureOfObservation = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, natureOfObservation);
        }

        [HttpPost]
        [Route("api/v1/natureofobservation")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateNatureOfObservationCommand(
                description: (string)body.description,
                internallyAvailable: (string)body.internallyAvailable,
                userIdRegistered: (int)body.userIdRegistered
                
            );

            var natureOfObservation = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, natureOfObservation);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/natureofobservation/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditNatureOfObservationCommand(
                id: id,
                description: (string)body.description,
                status: (string)body.status,
                internallyAvailable: (string)body.internallyAvailable
            );

            var natureOfObservation = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, natureOfObservation);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/natureofobservation/status/{id}")]
        public Task<HttpResponseMessage> UpdateStatus(int id, [FromBody]dynamic body)
        {
            var command = new UpdateStatusNatureOfObservationCommand(
                id: id
             );

            var natureOfObservation = _service.UpdateStatus(command);
            return CreateResponse(HttpStatusCode.OK, natureOfObservation);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/natureofobservation/internallyavailable/{id}")]
        public Task<HttpResponseMessage> UpdateInternallyAvailable(int id, [FromBody]dynamic body)
        {
            var command = new UpdateIAvaliableNatureOfObservationCommand(
                id: id
             );

            var natureOfObservation = _service.UpdateInternallyAvaliable(command);
            return CreateResponse(HttpStatusCode.OK, natureOfObservation);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/v1/natureofobservation/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var natureOfObservation = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, natureOfObservation);
        }
    }
}