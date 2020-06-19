using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParasMachineTestWebAPI.Services;
using ParasMachineTestWebAPI.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParasMachineTestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeDetails _employeeDetails;
        public EmployeeController(IEmployeeDetails employeeDetails)
        {
            _employeeDetails = employeeDetails;
        }
        [HttpGet]
        [Route("api/GetAll")]
        public IActionResult GetAll()
        {
            var employee= _employeeDetails.GetAll();
            if(employee!=null)
            {
                return Ok(employee);
            }
            else
            {
                return Ok("No Record Found");
            }
        }
        [HttpPost]
        [Route("api/SaveEmployee")]
        public IActionResult SaveEmployee([FromBody] EmployeeViewModel employeeViewModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            if(_employeeDetails.SaveEmployee(employeeViewModel))
            {
                return Ok("Employee Added Successfully");
            }
            else
            {
                return BadRequest();
            }
            
        }

    }
}
