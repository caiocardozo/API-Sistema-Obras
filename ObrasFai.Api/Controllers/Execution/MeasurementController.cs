using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ObrasFai.Domain.Commands.Execution.Measurement;
using ObrasFai.Domain.Services.Execution;

namespace ObrasFai.Api.Controllers.Execution
{
    public class MeasurementController : BaseController
    {
        private readonly IMeasurementApplicationService _service;

        public MeasurementController(IMeasurementApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/v1/measurement")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var measurement = _service.Get();
            return CreateResponse(HttpStatusCode.OK, measurement);
        }

        [HttpGet]
        [Route("api/v1/measurement/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var measurement = _service.Get(id);
            return CreateResponse(HttpStatusCode.OK, measurement);
        }

        [HttpPost]
        [Route("api/v1/measurement")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateMeasurementCommand(
                constructionId: (int)body.constructionId,
                contractId: (int)body.contractId,
                supervisorId: (Int16)body.supervisorId,
                date: (string)body.date,
                value: (decimal)body.value,
                comments: (string)body.comments,
                apportionmentCode: (int)body.apportionmentCode,
                chit: (int)body.chit,
                chitSeries: (string)body.chitSeries,
                userIdRegistered: (int)body.userIdRegistered
            );

            var measurement = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, measurement);
        }

        [HttpPut]
        //[Authorize]
        [Route("api/v1/measurement/{id}")]
        public Task<HttpResponseMessage> Put(Int16 id, [FromBody]dynamic body)
        {
            var command = new EditMeasurementCommand(
                id: (Int16)body.id,
                constructionId: (int)body.constructionId,
                contractId: (int)body.contractId,
                supervisorId: (Int16)body.supervisorId,
                date: (string)body.date,
                value: (decimal)body.value,
                comments: (string)body.comments,
                apportionmentCode: (int)body.apportionmentCode,
                chit: (int)body.chit,
                chitSeries: (string)body.chitSeries
            );

            var measurement = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, measurement);
        }

        [HttpDelete]
        //[Authorize]
        [Route("api/v1/measurement/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var measurement = _service.Delete(id);
            return CreateResponse(HttpStatusCode.OK, measurement);
        }

        [HttpGet]
        [Route("api/v1/measurementconstruction/{id}")]
        //[Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> GetMeasurementsConstruction(int id)
        {
            var measurement = _service.GetMeasurementsConstruction(id);
            return CreateResponse(HttpStatusCode.OK, measurement);
        }
    }
}