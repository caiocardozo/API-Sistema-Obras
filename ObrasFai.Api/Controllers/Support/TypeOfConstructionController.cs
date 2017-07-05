using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Support.TypeOfConstruction;
using ObrasFai.Domain.Services.Support;

namespace ObrasFai.Api.Controllers.Support
{
    public class TypeOfConstructionController : BaseController
    {
        private readonly ITypeOfConstructionApplicationService _service;

        public TypeOfConstructionController(ITypeOfConstructionApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/typeofconstruction")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var typeOfConstruction = _service.Get();
            return CreateResponse(HttpStatusCode.OK, typeOfConstruction);
        }

        [HttpGet]
        [Route("api/v1/typeofconstruction/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var typeOfConstruction = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, typeOfConstruction);
        }

        [HttpPost]
        [Route("api/v1/typeofconstruction")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateTypeOfConstructionCommand(
                description: (string)body.description,
                userIdRegistered: (int)body.userIdRegistered
            );

            var typeOfConstruction = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, typeOfConstruction);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/typeofconstruction/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditTypeOfConstructionCommand(
                id: id,
                description: (string)body.description,
                status: (string)body.status
            );

            var typeOfConstruction = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, typeOfConstruction);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/typeofconstruction/status/{id}")]
        public Task<HttpResponseMessage> UpdateStatus(int id, [FromBody]dynamic body)
        {
            var command = new UpdateStatusTOConstructionCommand(
                id: id
             );

            var typeOfConstruction = _service.UpdateStatus(command);
            return CreateResponse(HttpStatusCode.OK, typeOfConstruction);
        }


        [HttpDelete]
        //[Authorize]
        [Route("api/v1/typeofconstruction/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var typeOfConstruction = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, typeOfConstruction);
        }
    }
}