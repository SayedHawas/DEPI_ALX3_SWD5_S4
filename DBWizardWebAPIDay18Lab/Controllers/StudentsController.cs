using DBWizardWebAPIDay18Lab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DBWizardWebAPIDay18Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly TestDBContext _db;
        public StudentsController(TestDBContext db)
        {
            this._db = db;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            return await _db.Employees.ToListAsync();
        }

    }
}
