using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoBlock_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private readonly IPeliculasApplication _peliculaApplication;

        public PeliculaController(IPeliculasApplication peliculaApplication)
        {
            _peliculaApplication = peliculaApplication;
        }

        // GET: api/pelicula
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _peliculaApplication.Get();
            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        // GET api/pelicula/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _peliculaApplication.Get(id);
            if (result != null) {
                return Ok(result);
            }

            return NotFound();
        }

        // POST api/pelicula
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Pelicula pelicula)
        {
            var result = await _peliculaApplication.Post(pelicula);
            if (result != null) 
            {
                return Ok(result);           
            }

            return BadRequest();
        }

        // PUT api/pelicula/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/pelicula/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _peliculaApplication.Delete(id)) 
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
