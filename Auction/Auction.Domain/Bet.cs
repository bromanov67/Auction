namespace Auction.Domain
{
    public class Bet
    {
        /// <summary>
        /// Bet's id
        /// </summary>
        public int Id { get; init; }

        /// <summary>
        /// Person id who make bet
        /// </summary>
        public string AuthorId { get; init; }

        /// <summary>
        /// Lot's id
        /// </summary>
        public int LotId { get; init; }
        

        /// <summary>
        /// Sum of bet
        /// </summary>
        public decimal Amount { get; init; }

        public DateTime DateTime { get; init; }
    }
}
