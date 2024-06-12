using FluentResults;
using MediatR;


namespace Auction.Auction.Application.Mediator
{
    // Интерфейс для валидатора
    public interface IValidator<in T> where T : IBaseRequest
    {
        Result Validate(T request);
    }
}
