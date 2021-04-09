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
    public class ReservaController : ControllerBase
    {
        private readonly IReservaApplication _reservaApplication;

        public ReservaController(IReservaApplication reservaApplication)
        {
            _reservaApplication = reservaApplication;
        }

        // GET: api/reserva
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _reservaApplication.Get();
            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        // GET api/reserva/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _reservaApplication.Get(id);
            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        // POST api/reserva
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Reserva reserva)
        {
            var result = await _reservaApplication.Post(reserva);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        // PUT api/reserva/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/reserva/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _reservaApplication.Delete(id);
            return Ok();
        }
    }
}
