using FluentResults;
using FluentValidation;

namespace Auction.Auction.Application.Auctions.CreateAuction
{
    public class CreateActionCommandValidator : IValidator<CreateActionCommand>
    {
        public Result Validate(CreateActionCommand? request)
        {
            if (request is null)
                return Result.Fail("Не удалось распознать данные");

            if (string.IsNullOrWhiteSpace(request.Name))
                return Result.Fail("Пустое имя");

            if (request.DateEnd <= request.DateStart)
                return Result.Fail("Дата завершения не может быть меньше начала");

            if (request.DateStart == default)
                return Result.Fail("Дата начала передана некорректно");

            if (request.DateEnd == default)
                return Result.Fail("Дата завршения передана некорректно");

            return Result.Ok();

        }
    }
}
