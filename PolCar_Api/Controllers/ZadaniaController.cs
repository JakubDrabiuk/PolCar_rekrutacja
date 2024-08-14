using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PolCar_Api.Models;

namespace PolCar_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZadaniaController : ControllerBase
    {
        private readonly PolCarContext _context;

        public ZadaniaController(PolCarContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Zadanium>> GetZadania(int id = 0)
        {
            try
            {
                if (id == 0)
                {
                    return Ok(await _context.Zadania.ToListAsync());
                }
                else
                    return Ok(await _context.Zadania.Where(z => z.ZadId == id).ToListAsync());

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public async Task<ActionResult> AddZadanie([FromBody] Zadanium zadanie)
        {
            try
            {
                await _context.Zadania.AddAsync(zadanie);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        public async Task<ActionResult> UpdateZadanie([FromBody] Zadanium zadanie)
        {
            try
            {
                 _context.Zadania.Update(zadanie);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpDelete]
        public async Task<ActionResult> DeleteZadanie(int id)
        {

            try
            {
                return Ok();
               // return Ok(_context.Zadania.Remove(_context.Zadania.;
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
