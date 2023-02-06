using ExpertSender.Application.Employees.Commands.CreateEmployee;
using ExpertSender.Application.Employees.Commands.DeleteEmployeeCommnad;
using ExpertSender.Application.Employees.Queries.GetEmployeeDetail;
using ExpertSender.Application.Employees.Queries.GetEmployees;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpertSender.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController
    {
        /// <summary>
        /// Returns all employees.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EmployeesVm>> GetAllEmployees()
        {
            var vm = await Mediator.Send(new GetEmployeesQuery());
            return vm;
        }

        /// <summary>
        /// Returns single employee.
        /// </summary>
        [Route("{id}")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<EmployeeVm>> GetDiscussion(int id)
        {
            var vm = await Mediator.Send(new GetEmployeeCommand() { EmployeeId = id });
            return vm;
        }

        /// <summary>
        /// Create new employee
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeCommand command)
        {
            var createNewEmployee = await Mediator.Send(command);
            return Ok(createNewEmployee);
        }

        /// <summary>
        /// Delete employee
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var response = await Mediator.Send(new DeleteEmployeeCommand()
            {
                EmployeeId = id
            });
            return Ok(response);
        }
    }
}