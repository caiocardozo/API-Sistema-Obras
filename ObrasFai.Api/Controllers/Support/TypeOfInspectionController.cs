using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Support.TypeOfInspection;
using ObrasFai.Domain.Services.Support;

namespace ObrasFai.Api.Controllers.Support
{
    public class TypeOfInspectionController : BaseController
    {
        private readonly ITypeOfInspectionApplicationService _service;

        public TypeOfInspectionController(ITypeOfInspectionApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/typeofinspection")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var typeOfInspection = _service.Get();
            return CreateResponse(HttpStatusCode.OK, typeOfInspection);
        }

        [HttpGet]
        [Route("api/v1/typeofinspection/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var typeOfInspection = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, typeOfInspection);
        }

        [HttpPost]
        [Route("api/v1/typeofinspection")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateTypeOfInspectionCommand(
                description: (string)body.description,
                userIdRegistered: (int)body.userIdRegistered
            );

            var typeOfInspection = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, typeOfInspection);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/typeofinspection/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditTypeOfInspectionCommand(
                id: id,
                description: (string)body.description,
                status: (string)body.status
            );

            var typeOfInspection = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, typeOfInspection);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/typeofinspection/status/{id}")]
        public Task<HttpResponseMessage> UpdateStatus(int id, [FromBody]dynamic body)
        {
            var command = new UpdateStatusTOInspectionCommand(
                id: id
             );

            var typeOfInspection = _service.UpdateStatus(command);
            return CreateResponse(HttpStatusCode.OK, typeOfInspection);
        }


        [HttpDelete]
        //[Authorize]
        [Route("api/v1/typeofinspection/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var typeOfInspection = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, typeOfInspection);
        }
    }
}