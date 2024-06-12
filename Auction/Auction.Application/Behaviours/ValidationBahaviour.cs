using Auction.Auction.Application.Auctions.CreateAuction;
using Auction.Auction.Application.Mediator;
using FluentResults;
using MediatR;

namespace Auction.Auction.Application.Behaviours
{
    public class ValidationBahaviour : IPipelineBehavior<CreateActionCommand, ResultBase>
    {
        private readonly IValidator<CreateActionCommand> _validator;
        public ValidatonBehaviour(IValidator<CreateActionCommand> validator)
        {
            _validator = validator;
        }
        public async Task<ResultBase> Handle(CreateActionCommand request, RequestHandlerDelegate<ResultBase> next, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);
            if (validationResult.IsFailed)
                return validationResult;

            await next();
        }
    }
}
