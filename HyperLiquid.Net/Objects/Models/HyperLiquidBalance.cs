using CryptoExchange.Net.Converters.SystemTextJson;
using HyperLiquid.Net.Converters;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HyperLiquid.Net.Objects.Models
{
    /// <summary>
    /// Spot balances
    /// </summary>
    [SerializationModel]
    public record HyperLiquidBalances
    {
        /// <summary>
        /// Balances
        /// </summary>
        [JsonPropertyName("balances")]
        public HyperLiquidBalance[] Balances { get; set; } = [];
        /// <summary>
        /// Portfolio margin enabled. Only returned for accounts in portfolio margin mode
        /// </summary>
        [JsonPropertyName("portfolioMarginEnabled")]
        public bool? PortfolioMarginEnabled { get; set; }
        /// <summary>
        /// Portfolio margin ratio. Only returned for accounts in portfolio margin mode
        /// </summary>
        [JsonPropertyName("portfolioMarginRatio")]
        public decimal? PortfolioMarginRatio { get; set; }
        /// <summary>
        /// Portfolio margin borrow ratio per token
        /// </summary>
        [JsonConverter(typeof(TokenToConverter))]
        [JsonPropertyName("tokenToPortfolioBorrowRatio")]
        public Dictionary<long, decimal>? TokenPortfolioBorrowRatio { get; set; }
        /// <summary>
        /// Portfolio margin supply ratio per token
        /// </summary>
        [JsonConverter(typeof(TokenToConverter))]
        [JsonPropertyName("tokenToPortfolioSupplyRatio")]
        public Dictionary<long, decimal>? TokenPortfolioSupplyRatio { get; set; }
        /// <summary>
        /// Quantity per token which is available to deploy, withdraw or transfer after the maintenance margin
        /// requirement and any holds are accounted for. Only returned for accounts in unified account or portfolio
        /// margin mode, which makes it a usable signal that an account is no longer in standard mode
        /// </summary>
        [JsonConverter(typeof(TokenToConverter))]
        [JsonPropertyName("tokenToAvailableAfterMaintenance")]
        public Dictionary<long, decimal>? TokenAvailableAfterMaintenance { get; set; }
    }

    /// <summary>
    /// Balance info
    /// </summary>
    [SerializationModel]
    public record HyperLiquidBalance
    {
        /// <summary>
        /// Asset
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// Token
        /// </summary>
        [JsonPropertyName("token")]
        public int Token { get; set; }
        /// <summary>
        /// In holding
        /// </summary>
        [JsonPropertyName("hold")]
        public decimal Hold { get; set; }
        /// <summary>
        /// In holding, before portfolio margin borrow capacity is netted off. Null when not sent, which has been
        /// observed for tokens carrying a zero <see cref="Hold"/>. Subtracting it from <see cref="Total"/> leaves the
        /// balance actually owned and unencumbered, whereas subtracting <see cref="Hold"/> leaves an amount that also
        /// includes what could be borrowed
        /// </summary>
        [JsonPropertyName("spotHold")]
        public decimal? SpotHold { get; set; }
        /// <summary>
        /// Total
        /// </summary>
        [JsonPropertyName("total")]
        public decimal Total { get; set; }
        /// <summary>
        /// Entry notional
        /// </summary>
        [JsonPropertyName("entryNtl")]
        public decimal EntryNotional { get; set; }
    }
}
