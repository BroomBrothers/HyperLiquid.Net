using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace HyperLiquid.Net.Objects.Models
{
    /// <summary>
    /// Spot balance update
    /// </summary>
    [SerializationModel]
    public record HyperLiquidBalanceUpdate
    {
        /// <summary>
        /// User address
        /// </summary>
        [JsonPropertyName("user")]
        public string User { get; set; } = string.Empty;
        /// <summary>
        /// Spot balances
        /// </summary>
        [JsonPropertyName("spotState")]
        public HyperLiquidBalances SpotBalances { get; set; } = default!;
    }
}
