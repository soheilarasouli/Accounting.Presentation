using Accounting.Application.AccountGroups.Queries.Find;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.Presentation.Controllers
{ 
    public class AccountGroupController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountGroupController(IMediator mediator)
        {
           _mediator = mediator;
        }

        [HttpGet("GetAccountGroup")]
        public async Task<IActionResult> GetAccountGroupById(Guid id)
        {
            var accountGroup = _mediator.Send(new FindAccountGroupQuery { Id = id });

            if(accountGroup == null)
                return NotFound();

            return Ok(accountGroup);
        }
    }
}
