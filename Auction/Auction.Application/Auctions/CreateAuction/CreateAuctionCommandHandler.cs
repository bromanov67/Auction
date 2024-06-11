using MediatR;
using FluentResults;

namespace Auction.Auction.Application.Auctions.CreateAuction
{
    public class CreateAuctionCommandHandler : IRequestHandler <CreateActionCommand, Result>
    {
        public Task<Result> Handle(CreateActionCommand request, CancellationToken cancellationToken) 
        {
            return Task.FromResult(Result.Ok());
        }
    }
}
