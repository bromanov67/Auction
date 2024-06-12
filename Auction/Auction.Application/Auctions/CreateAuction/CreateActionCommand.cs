using MediatR;
using FluentResults;
using System.Text.Json.Serialization;

namespace Auction.Auction.Application.Auctions.CreateAuction
{


    /// <summary>
    /// Команда на создание аукциона
    /// </summary>
    public record CreateActionCommand : IRequest<ResultBase>
    {
        /// <summary>
        /// Название команд аукциона
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; init; }

        [JsonPropertyName("dateStart")]
        public DateTime DateStart { get; init; }

        [JsonPropertyName("dateEnd")]
        public DateTime DateEnd { get; init; }
    }
}
