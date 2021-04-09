using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using VideoBlock_API.Filters;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoBlock_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ExceptionHandlerFilter))]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplication _rolApplication;

        public UsuarioController(IUsuarioApplication rolApplication)
        {
            _rolApplication = rolApplication;
        }

        // GET: api/usuario
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _rolApplication.Get();
            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        // GET api/usuario/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _rolApplication.Get(id);
            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        // POST api/usuario
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuario rol)
        {
            var result = await _rolApplication.Post(rol);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        // PUT api/usuario/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/usuario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _rolApplication.Delete(id);
            return Ok();
        }
    }
}
