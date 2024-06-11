using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Controllers;
/// <summary>
/// Contorller for creation auction
/// </summary>
/// 

[ApiController]
[Route("api/v1/auctions")]

public class AuctionController : ControllerBase
{
    private readonly IMediator _mediator;



    [HttpPost]
    public async Task<IActionResult> CreateAuctionAsync(CancellationToken cancellationToken)
    {
        await _mediator.Send(new object(), cancellationToken);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAuctionAsync(int id)
    {
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAuctionAsync()
    {
        return Ok();
    }
}