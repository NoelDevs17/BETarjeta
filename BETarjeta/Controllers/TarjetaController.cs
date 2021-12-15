using BETarjeta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BETarjeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        
        public TarjetaController(AplicationDbContext context)
        {
            _context = context;
        }


        // GET: api/<TarjetaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listTarjeta =  await _context.TarjetaCredito.ToListAsync();
                return Ok(listTarjeta);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

      

        // POST api/<TarjetaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TarjetaCredito tarjeta)
        {
            try
            {
                _context.Add(tarjeta);
               await _context.SaveChangesAsync();
                return Ok(tarjeta);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // PUT api/<TarjetaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TarjetaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
