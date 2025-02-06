using FirstWebApiProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace FirstWebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext _context = null;
        public EmployeesController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAll()
        {
           var data = this._context.Employees.ToList();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmpById(int id)
        {
            var rec = this._context.Employees.FirstOrDefault(e=>e.EmpId == id);
            if(rec != null)
            {
                return Ok(rec);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            if(employee == null)
            {
                return BadRequest("Employee details not set");
            }
            this._context.Employees.Add(employee);
            this._context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEmployee(int id, Employee employee)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            return Ok();
        }
    }
}
