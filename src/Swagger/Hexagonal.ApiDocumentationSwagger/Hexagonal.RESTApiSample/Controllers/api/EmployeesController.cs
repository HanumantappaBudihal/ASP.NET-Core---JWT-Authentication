using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hexagonal.RESTApiSample.Models;

namespace Hexagonal.RESTApiSample.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly WebApiLearningContext _context;

        public EmployeesController(WebApiLearningContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Get all employees
        /// </summary>
        /// <remarks>
        /// It's a get method, just return all employee details in database
        /// 
        /// </remarks>       
        /// <returns>returns all employee items </returns>
        /// <response code="201">Returns the all employees</response>
        /// <response code="400">If the item is null</response>
        [HttpGet]        
        public IEnumerable<Employees> GetEmployees()
        {
            return _context.Employees;
        }

        /// <summary>
        /// Find the employee details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployees([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employees = await _context.Employees.FindAsync(id);

            if (employees == null)
            {
                return NotFound();
            }

            return Ok(employees);
        }

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployees([FromRoute] int id, [FromBody] Employees employees)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employees.Id)
            {
                return BadRequest();
            }

            _context.Entry(employees).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        /// <summary>
        /// Creates a employee.
        /// </summary>
        /// <remarks>
        /// Note that the Id is a auto generated and it is an integer.
        ///  
        ///     POST: api/Employees
        ///     {
        ///     "Id": 0,
        ///     "FirstName": "string",
        ///     "LastName": "string",
        ///     "Gender": "string",
        ///     "Salary": 0
        ///     }
        /// 
        /// </remarks>
        /// <param name="employee"></param>
        /// <returns>New Created employee </returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        // POST: api/Employees
        [HttpPost]
        public async Task<IActionResult> PostEmployees([FromBody] Employees employees)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Employees.Add(employees);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployees", new { id = employees.Id }, employees);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployees([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employees = await _context.Employees.FindAsync(id);
            if (employees == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employees);
            await _context.SaveChangesAsync();

            return Ok(employees);
        }

        private bool EmployeesExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}