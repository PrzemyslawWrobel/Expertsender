using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpertSender.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController
    {
        ///// <summary>
        ///// Returns all items.
        ///// </summary>
        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        //[ProducesResponseType(StatusCodes.Status403Forbidden)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]

        //public async Task<ActionResult<EmployeesVm>> GetAllEmployees()
        //{
        //    var vm = await Mediator.Send(new GetEmployeesQuery());
        //    return vm;
        //}

        ///// <summary>
        ///// Create new Product
        ///// </summary>
        ///// <returns></returns>
        //[HttpPost]
        //public async Task<IActionResult> Create(CreateEmployeeCommand command)
        //{
        //    var createNewEmployee = await Mediator.Send(command);
        //    return Ok(createNewEmployee);
        //}
    }
}