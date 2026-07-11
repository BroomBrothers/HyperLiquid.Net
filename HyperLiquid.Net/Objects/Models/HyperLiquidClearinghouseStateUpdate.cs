using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace HyperLiquid.Net.Objects.Models
{
    /// <summary>
    /// Futures clearinghouse state update
    /// </summary>
    [SerializationModel]
    public record HyperLiquidClearinghouseStateUpdate
    {
        /// <summary>
        /// User address
        /// </summary>
        [JsonPropertyName("user")]
        public string User { get; set; } = string.Empty;

        /// <summary>
        /// Perpetual DEX name
        /// </summary>
        [JsonPropertyName("dex")]
        public string Dex { get; set; } = string.Empty;

        /// <summary>
        /// Futures account state
        /// </summary>
        [JsonPropertyName("clearinghouseState")]
        public HyperLiquidFuturesAccount ClearinghouseState { get; set; } = default!;
    }
}
