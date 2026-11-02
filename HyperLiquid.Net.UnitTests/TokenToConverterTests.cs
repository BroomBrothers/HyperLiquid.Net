using HyperLiquid.Net.Objects.Models;
using NUnit.Framework;
using System.Text.Json;

namespace HyperLiquid.Net.UnitTests
{
    [TestFixture]
    public class TokenToConverterTests
    {
        [Test]
        public void DeserializeUnifiedAccountSpotClearinghouseState()
        {
            var json = "{\"balances\":[{\"coin\":\"USDC\",\"token\":0,\"total\":\"346303.77971716\",\"hold\":\"34878.0\",\"entryNtl\":\"0.0\"}],\"tokenToAvailableAfterMaintenance\":[[0,\"328864.77971716\"],[235,\"2.76457493\"]]}";

            var result = JsonSerializer.Deserialize<HyperLiquidBalances>(json, HyperLiquidExchange._serializerContext);

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Balances, Has.Length.EqualTo(1));
            Assert.That(result.TokenAvailableAfterMaintenance, Is.Not.Null);
            Assert.That(result.TokenAvailableAfterMaintenance, Has.Count.EqualTo(2));
            Assert.That(result.TokenAvailableAfterMaintenance![0], Is.EqualTo(328864.77971716m));
            Assert.That(result.TokenAvailableAfterMaintenance[235], Is.EqualTo(2.76457493m));
        }

        [Test]
        public void DeserializeStandardModeSpotClearinghouseState()
        {
            var json = "{\"balances\":[{\"coin\":\"USDC\",\"token\":0,\"total\":\"2.77363\",\"hold\":\"0.0\",\"entryNtl\":\"0.0\"}]}";

            var result = JsonSerializer.Deserialize<HyperLiquidBalances>(json, HyperLiquidExchange._serializerContext);

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.TokenAvailableAfterMaintenance, Is.Null);
            Assert.That(result.PortfolioMarginEnabled, Is.Null);
        }
    }
}
