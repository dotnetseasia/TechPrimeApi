using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechprimeAssignment.Application.Features.ProjectFeatures.AddProjectData;
using TruckLotParking.Application.Features.UserFeatures.CreateUser;

namespace TechprimeAssignment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<AddProjectDataResponse>> AddProjectData(AddProjectDataRequest request,
         CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
