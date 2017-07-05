using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Support.TypeOfBond;
using ObrasFai.Domain.Services.Support;

namespace ObrasFai.Api.Controllers.Support
{
    public class TypeOfBondController : BaseController
    {
        private readonly ITypeOfBondApplicationService _service;

        public TypeOfBondController(ITypeOfBondApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/typeofbond")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var typeOfBond = _service.Get();
            return CreateResponse(HttpStatusCode.OK, typeOfBond);
        }

        [HttpGet]
        [Route("api/v1/typeofbond/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var typeOfBond = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, typeOfBond);
        }

        [HttpPost]
        [Route("api/v1/typeofbond")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateTypeOfBondCommand(
                description: (string)body.description,
                userIdRegistered: (int)body.userIdRegistered
            );

            var typeOfBond = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, typeOfBond);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/typeofbond/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditTypeOfBondCommand(
                id: id,
                description: (string)body.description,
                status: (string)body.status
            );

            var typeOfBond = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, typeOfBond);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/typeofbond/status/{id}")]
        public Task<HttpResponseMessage> UpdateStatus(int id, [FromBody]dynamic body)
        {
            var command = new UpdateStatusTOBondCommand(
                id: id
             );

            var typeOfBond = _service.UpdateStatus(command);
            return CreateResponse(HttpStatusCode.OK, typeOfBond);
        }


        [HttpDelete]
        //[Authorize]
        [Route("api/v1/typeofbond/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var typeOfBond = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, typeOfBond);
        }
    }
}