using Day16LabWebAPI9Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day16LabWebAPI9Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly WebAPIDBContext _DB;

        public DepartmentsController(WebAPIDBContext db)
        {
            this._DB = db;
        }

        //Get 
        [HttpGet]
        //public IEnumerable<Department> GetAll()
        public IActionResult GetAll()
        {
            return Ok(_DB.Departments.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var dep = _DB.Departments.Find(id);
            if (dep == null) return NotFound();
            else return Ok(dep);
        }
        [HttpPost]
        public IActionResult Create(Department newDepartment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(newDepartment);
            }
            else
            {
                _DB.Departments.Add(newDepartment);
                _DB.SaveChanges();
                return Created();
            }
        }
        [HttpPut]
        public IActionResult Edit(Department updateDepartment, int id)
        {
            var dep = _DB.Departments.Find(id);
            if (dep == null) return BadRequest();
            else
            {
                dep.Name = updateDepartment.Name;
                dep.Location = updateDepartment.Location;
                dep.ManagerName = updateDepartment.ManagerName;
                _DB.SaveChanges();
                return NoContent();
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var dep = _DB.Departments.Find(id);
            if (dep == null) return BadRequest();
            else
            {
                _DB.Departments.Remove(dep);
                _DB.SaveChanges();
                return NoContent();
            }
        }
    }
}
