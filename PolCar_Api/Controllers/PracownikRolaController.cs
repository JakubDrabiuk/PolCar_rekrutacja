using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PolCar_Api.Models;

namespace PolCar_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracownikRolaController : ControllerBase
    {
        private readonly PolCarContext _context;

        public PracownikRolaController(PolCarContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<PracownikRola>> Get()
        {
            try
            {
                return Ok(await _context.PracownikRolas.ToListAsync());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
