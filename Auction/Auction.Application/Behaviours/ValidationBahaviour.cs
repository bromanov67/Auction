using Auction.Auction.Application.Auctions.CreateAuction;
using FluentResults;
using MediatR;

namespace Auction.Auction.Application.Behaviours
{
    public class ValidationBahaviour : IPipelineBehavior<CreateActionCommand, Result>
    {
        public Task<Result> Handle(CreateActionCommand request, RequestHandlerDelegate<Result> next, CancellationToken cancellationToken)
        {

        }
    }
}
