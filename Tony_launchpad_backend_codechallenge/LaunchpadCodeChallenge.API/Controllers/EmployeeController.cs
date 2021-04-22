using LaunchpadCodeChallenge.App.Service.Interface;
using LaunchpadCodeChallenge.Models.Entitities;
using LaunchpadCodeChallenge.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("employees")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
        {
            var employee = await _employeeService.GetAll();
            return Ok(employee);
        }

        [HttpGet("list")] //("list")
        public async Task<ActionResult<List<Department>>> ListAll(Department dept)
        {
            var results = await _employeeService.ListAll();
            //var models = results.Select(dept => new Department(dept));
            return Ok(results);

        }
    }
}
