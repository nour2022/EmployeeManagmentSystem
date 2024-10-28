using EmployeeManagmentSystem.Application.DTO;
using EmployeeManagmentSystem.Application.Services;
using EmployeeManagmentSystem.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EmployeeManagmentSystem.API.Controllers
{
   
    [ApiController]
    [Route("api/employees")]
    public class EmployeeController : Controller
    {
        private EmployeeService _employeeService;
        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet("/api/employees/{id}")]
        public IActionResult GetEmployee(int id)
        {
           var Employee =_employeeService.GetById(id);
            return Ok(Employee);
        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var Employees = _employeeService.GetAll();
            return Ok(Employees);
        }
        [HttpGet("pageNumber={pageNumber}&pageSize={pageSize}")]
        public IActionResult GetPagedEmpolyees(int pageSize=10,int pageNumber=1)
        {
            var PagedEmployees = _employeeService.GetPagedEmpolyees(pageSize,pageNumber);
            if(PagedEmployees == null)
                return NotFound();
            return Ok(PagedEmployees);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] EmployeeDTO employeeDTO)
        {
             _employeeService.Insert(employeeDTO);
            return Ok();
        }

        [HttpPut("/api/employees/{id}")]
        public IActionResult UpdateEmployee([FromBody] EmployeeDTO employeeDTO,int id)
        {
            if (_employeeService.GetById(id) != null)
            {
                _employeeService.Update(employeeDTO, id);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("/api/employees/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (_employeeService.Delete(id))
            
                return Ok();
         
            else
           
                return NotFound();
           
        }

        [HttpPost("search")]
        public IActionResult Search([FromBody] string query)
        {
            var result = _employeeService.Search(query);
            return Ok(result);
        }

    }
}
