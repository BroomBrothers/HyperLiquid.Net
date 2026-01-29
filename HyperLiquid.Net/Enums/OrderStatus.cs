using System.Text.Json.Serialization;
using CryptoExchange.Net.Converters.SystemTextJson;
using CryptoExchange.Net.Attributes;

namespace HyperLiquid.Net.Enums
{
    /// <summary>
    /// Order status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<OrderStatus>))]
    public enum OrderStatus
    {
        /// <summary>
        /// Filled
        /// </summary>
        [Map("filled")]
        Filled,
        /// <summary>
        /// Open
        /// </summary>
        [Map("open")]
        Open,
        /// <summary>
        /// Canceled
        /// </summary>
        [Map("canceled", "reduceOnlyCanceled")]
        Canceled,
        /// <summary>
        /// Trigger
        /// </summary>
        [Map("triggered")]
        Triggered,
        /// <summary>
        /// Rejected
        /// </summary>
        [Map("rejected")]
        Rejected,
        /// <summary>
        /// Margin canceled
        /// </summary>
        [Map("marginCanceled")]
        MarginCanceled,
        /// <summary>
        /// Rejected; insufficient balance
        /// </summary>
        [Map("insufficientSpotBalanceRejected")]
        RejectedInsufficientBalance,
        /// <summary>
        /// Rejected; IOC 
        /// </summary>
        [Map("iocCancelRejected")]
        RejectedIOC,
        /// <summary>
        /// Rejected; price rejected 
        /// </summary>
        [Map("badAloPxRejected")]
        RejectedBadPrice,
        /// <summary>
        /// Rejected; insufficient margin
        /// </summary>
        [Map("perpMarginRejected")]
        RejectedInsufficientMargin,
        /// <summary>
        /// Rejected; order value too small
        /// </summary>
        [Map("minTradeNtlRejected")]
        RejectedMinValue,
        /// <summary>
        /// Rejected; sibling filled/canceled
        /// </summary>
        [Map("siblingFilledCanceled")]
        RejectedSiblingFilledCanceled,
        /// <summary>
        /// Reduce only rejected
        /// </summary>
        [Map("reduceOnlyRejected")]
        ReduceOnlyRejected,
        /// <summary>
        /// Cancelled as a self trade
        /// </summary>
        [Map("selfTradeCanceled")]
        SelfTradeCanceled,
        /// <summary>
        /// Cancelled due to Open Interest cap on the Symbol
        /// </summary>
        [Map("openInterestCapCanceled")]
        OpenInterestCapCanceled,
        /// <summary>
        /// Cancelled due to insufficient margin available due to a vault withdrawal
        /// </summary>
        [Map("vaultWithdrawalCanceled")]
        VaultWithdrawalCanceled,
        /// <summary>
        /// Cancelled due to the Symbol being delisted
        /// </summary>
        [Map("delistedCanceled")]
        DelistedCanceled,
        /// <summary>
        /// Cancelled due to the Position being liquidated
        /// </summary>
        [Map("liquidatedCanceled")]
        LiquidatedCanceled,
        /// <summary>
        /// Cancelled as scheduled by the order expiry
        /// </summary>
        [Map("scheduledCancel")]
        ScheduledCanceled,

        /// <summary>
        /// Waiting for main order to fill before placing this order
        /// </summary>
        WaitingFill,
        /// <summary>
        /// Waiting for trigger price to be reached before placing this order
        /// </summary>
        WaitingTrigger
    }
}
