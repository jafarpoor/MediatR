using ApiProject.PersonFeatures.Command;
using ApiProject.PersonFeatures.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator mediator;
        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddPersonCommandModel command)
        {
            return Ok(await mediator.Send(command));
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await mediator.Send(new GetAllPersonQueryModel()));
        }

    }
}
