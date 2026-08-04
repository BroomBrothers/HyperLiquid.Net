using System.Text.Json.Serialization;
using CryptoExchange.Net.Converters.SystemTextJson;
using HyperLiquid.Net.Objects.Models;

namespace HyperLiquid.Net.Objects.Internal;

[SerializationModel]
internal record HyperLiquidOrderHistoryUpdate
{
    [JsonPropertyName("isSnapshot")]
    public bool IsSnapshot { get; set; }
    [JsonPropertyName("orderHistory")]
    public HyperLiquidOrderStatus[] Orders { get; set; } = [];
    [JsonPropertyName("user")]
    public string User { get; set; } = string.Empty;
}
