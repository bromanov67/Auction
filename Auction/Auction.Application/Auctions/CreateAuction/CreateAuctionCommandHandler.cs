using MediatR;
using FluentResults;

namespace Auction.Auction.Application.Auctions.CreateAuction
{
    /// <summary>
    /// Обраточик команды создания аукциона
    /// </summary>
    public class CreateAuctionCommandHandler : IRequestHandler <CreateActionCommand, ResultBase>
    {

        /// <summary>
        /// inheritdoc
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<ResultBase> Handle(CreateActionCommand request, CancellationToken cancellationToken) 
        {
            return Task.FromResult<ResultBase>(Result.Ok(Guid.NewGuid()));
        }
    }
}
