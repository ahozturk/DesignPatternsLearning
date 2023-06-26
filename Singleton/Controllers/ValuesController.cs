using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Singleton.Services;

namespace Singleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        readonly DatabaseService _databaseService;
        public ValuesController()
        {
            _databaseService = DatabaseService.Instance;
        }
        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            return Ok(_databaseService.GetAll());
        }

        [HttpGet("[action]/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_databaseService.GetById(id));
        }
    }
}
