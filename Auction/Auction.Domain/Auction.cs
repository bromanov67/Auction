namespace Auction.Domain
{
    /// <summary>
    /// Auction
    /// </summary>
    public class Auction
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public int AuthorId { get; init; }

        public DateTime DateStart { get; init; }

        /// <summary>
        /// Flag is auction creating?
        /// </summary>
        public bool IsCreation { get; init; }


        public readonly DateTime _dateEnd;

        public DateTime DateEnd
        {
            get
            {
                //Add 30 seconds for lot if bet was make earlier then 30 seconds to end

                var maxBetDate = Lots.SelectMany(l => l.Bets).Max(s => s.DateTime).AddSeconds(30);

                return _dateEnd > maxBetDate ? _dateEnd : maxBetDate;
            }
            init => _dateEnd = value;
        }

        public AuctionStatus Status
        {
            get
            {
                var dateTimeNow = DateTime.UtcNow;

                if (IsCreation)
                    return AuctionStatus.Creation;

                if (dateTimeNow > DateStart && dateTimeNow < DateEnd)
                    return AuctionStatus.Bidding;

                if (dateTimeNow < DateStart)
                    return AuctionStatus.WaitBidding;

                return AuctionStatus.Complete;
            }
        }

        /// <summary>
        /// Lots
        /// </summary>
        public Dictionary<int, Lot> Lots { get; init; } = new();
    }
}
