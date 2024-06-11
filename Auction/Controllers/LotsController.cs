using Microsoft.AspNetCore.Mvc;

namespace Auction.Controllers
{
    [ApiController]
    [Route("api/v1/lots")]
    public class LotsController : ControllerBase
    {
        public async Task<IActionResult> CreateLotAsync()
        {
            return Ok();
        }
        
        public async Task<IActionResult> DeleteLotAsync()
        {
            return Ok();
        }

        public async Task<IActionResult> UpdateLotAsync()
        {
            return Ok();
        }
    }
}
