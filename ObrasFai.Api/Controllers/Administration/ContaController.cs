using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Administration.Person;
using ObrasFai.Domain.Services.Administration;
using ObrasFai.Domain.ValueObjects;

namespace ObrasFai.Api.Controllers.Administration
{
    public class ContaController : BaseController
    {
        private readonly IPersonApplicationService _service;

        public ContaController(IPersonApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/usuario")]
        [Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var person = _service.Get();
                
                ;
            return CreateResponse(HttpStatusCode.OK, person);
        }

        [HttpPost]
        [Route("api/users")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreatePersonCommand(
                name: (string)body.name,
                birthDate: (DateTime)body.birthDate,
                email: (Email)body.email,
                cpf: (Cpf)body.cpf,
                username: (string)body.username,
                password: (string)body.password
            );

            var person = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, person);   
        }
    }
}