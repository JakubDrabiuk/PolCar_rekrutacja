using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PolCar_Api.Models;

namespace PolCar_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracownikController : ControllerBase
    {
        private readonly PolCarContext _context;

        public PracownikController(PolCarContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<Pracownik>> Get()
        {
            try
            {
                return Ok(await _context.Pracowniks.ToListAsync());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
