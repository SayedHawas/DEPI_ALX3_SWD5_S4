using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIDay4Day20Lab.Models;

namespace WebAPIDay4Day20Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Teachers2Controller : ControllerBase
    {
        //https://localhost:7297/api/Teachers
        private readonly AppDbContext _db;
        public Teachers2Controller(AppDbContext db)
        {
            this._db = db;
        }
        //Controller Factor

        //[HttpGet]
        //public IEnumerable<Teacher> Get()
        //{
        //    return _db.Teachers.ToList();
        //}

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok(_db.Teachers.ToList());
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> Get()
        {
            var result = await _db.Teachers.ToListAsync();
            return Ok(result);
        }

        //CRUD
    }
}
