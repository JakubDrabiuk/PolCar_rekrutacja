using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PolCar_Api.Models;

namespace PolCar_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriorytetController : ControllerBase
    {
        private readonly PolCarContext _context;

        public PriorytetController(PolCarContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task < ActionResult<Priorytet>> Get()
        {
            try
            {
                return Ok(await _context.Priorytets.ToListAsync());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            
        }
    }
}
