using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PolCar_Api.Models;

namespace PolCar_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZadaniaStatusController : ControllerBase
    {
        private readonly PolCarContext _context;

        public ZadaniaStatusController(PolCarContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<ZadaniaStatus>> Get()
        {
            try
            {
                return Ok(await _context.ZadaniaStatuses.ToListAsync());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
