using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task_Multiple_DB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultipleDatabaseController : ControllerBase
    {
        private readonly IDB1Repository _dB1Repository;
        private readonly IDB2Repository _dB2Repository;

        public MultipleDatabaseController(IDB1Repository DB1Repository, IDB2Repository DB2Repository)
        {
            _dB1Repository = DB1Repository;
            _dB2Repository = DB2Repository;
        }

        [HttpGet("Entity1")]
        public async Task<IActionResult> GetEntity1()
        {
            var Entity1 = await _dB1Repository.GetAll();
            return Ok(Entity1);
        }

        [HttpGet("Entity1/{id}")]
        public async Task<IActionResult> GetEntity1ById(int id)
        {
            var Entity1 = await _dB1Repository.GetById(id);
            if (Entity1 == null)
            {
                return NotFound();
            }
            return Ok(Entity1);
        }


        [HttpGet("Entity2")]
        public async Task<IActionResult> GetEntity2()
        {
            var Entity2 = await _dB2Repository.GetAll();
            return Ok(Entity2);
        }

        [HttpGet("Entity2/{id}")]
        public async Task<IActionResult> GetEntity2ById(int id)
        {
            var Entity2 = await _dB2Repository.GetById(id);
            if (Entity2 == null)
            {
                return NotFound();
            }
            return Ok(Entity2);
        }
    }
}
