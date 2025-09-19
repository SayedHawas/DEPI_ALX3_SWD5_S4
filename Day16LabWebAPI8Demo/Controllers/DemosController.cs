using Microsoft.AspNetCore.Mvc;

namespace Day16LabWebAPI8Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemosController : ControllerBase
    {
        private static List<string> Names = new List<string>() { "Ahmed", "Ali", "Sayed", "Mariem", "Retaj" };


        public DemosController()
        {

        }

        // https://localhost:7272/api/demos
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Names;
        }
        // https://localhost:7272/api/demos/1  RouteValue
        [HttpGet("{id:int}")]
        //[Route("{id}")]
        public string GetByID(int id)
        {
            return Names[id];
        }
        [HttpGet("{name:alpha}")]
        public string GetByName(string name)
        {
            return Names.FirstOrDefault(a => a == name);
        }

        [HttpGet("/api/forname/{name}")]
        public string GetByFullName(string name)
        {
            return Names.FirstOrDefault(a => a == name);
        }
        [HttpPost]
        public string Create(string newName)
        {
            Names.Add(newName);
            return "Save Done ...";
        }
    }
}
