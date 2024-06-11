using FluentResults;

namespace Auction.Domain
{
    public class Lot
    {
        public int Id { get; init; }

        public int AuctionId { get; init; }

        public string Name { get; init; }

        public string Code { get; init; }

        public string Description { get; init; }

        public Lotstatus Status { get; init; }

        public IReadOnlyCollection<Bet> Bets => _bets;

        private List<Bet> _bets = new List<Bet>();

        public IReadOnlyCollection<string> Images { get; init; } = new List<string>();


        /// <summary>
        /// try to do bet
        /// </summary>
        /// <param name="bet"></param>
        /// <returns> Result of operation </returns>
        public Result TryDoBet(Bet bet)
        {
            if (Status != Lotstatus.Bidding)
            {
                return Result.Fail("Невозможно сделать ставку. Торги завершены");
            }
            if (_bets.Any(b => b.Amount >= bet.Amount))
            {
                return Result.Fail("Ставка была перекрыта другим человеком");
            }
            _bets.Add(bet);

            return Result.Ok();
        }


    }
}
