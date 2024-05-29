using FxRateApi.Models;
using System.Linq;

namespace FxRateApi.Data
{
    public static class FxRateDataset
    {
        public static Dictionary<string, List<FxRate>> OriginalRates { get; set; } = new Dictionary<string, List<FxRate>>(){
            {"USD", new List<FxRate> {
                new FxRate{ Currency = "EUR", Rate = 0.85f },
                new FxRate{ Currency = "GBP", Rate = 0.75f },
                new FxRate{ Currency = "JPY", Rate = 110.0f },
                new FxRate{ Currency = "AUD", Rate = 1.35f },
                new FxRate{ Currency = "CAD", Rate = 1.25f },
                new FxRate{ Currency = "CHF", Rate = 0.90f },
                new FxRate{ Currency = "CNY", Rate = 6.5f },
            }},
            {"EUR", new List<FxRate> {
                new FxRate{ Currency = "USD", Rate = 1.18f },
                new FxRate{ Currency = "GBP", Rate = 0.88f },
                new FxRate{ Currency = "JPY", Rate = 129.0f },
                new FxRate{ Currency = "AUD", Rate = 1.59f },
                new FxRate{ Currency = "CAD", Rate = 1.47f },
                new FxRate{ Currency = "CHF", Rate = 1.06f },
                new FxRate{ Currency = "CNY", Rate = 7.65f },
            }},
            {"GBP", new List<FxRate> {
                new FxRate{ Currency = "USD", Rate = 1.33f },
                new FxRate{ Currency = "EUR", Rate = 1.14f },
                new FxRate{ Currency = "JPY", Rate = 146.0f },
                new FxRate{ Currency = "AUD", Rate = 1.81f },
                new FxRate{ Currency = "CAD", Rate = 1.67f },
                new FxRate{ Currency = "CHF", Rate = 1.21f },
                new FxRate{ Currency = "CNY", Rate = 8.71f },
            }},
            {"JPY", new List<FxRate> {
                new FxRate{ Currency = "USD", Rate = 0.0091f },
                new FxRate{ Currency = "EUR", Rate = 0.0078f },
                new FxRate{ Currency = "GBP", Rate = 0.0068f },
                new FxRate{ Currency = "AUD", Rate = 0.012f },
                new FxRate{ Currency = "CAD", Rate = 0.011f },
                new FxRate{ Currency = "CHF", Rate = 0.0083f },
                new FxRate{ Currency = "CNY", Rate = 0.059f },
            }},
            {"AUD", new List<FxRate> {
                new FxRate{ Currency = "USD", Rate = 0.74f },
                new FxRate{ Currency = "EUR", Rate = 0.63f },
                new FxRate{ Currency = "GBP", Rate = 0.55f },
                new FxRate{ Currency = "JPY", Rate = 81.0f },
                new FxRate{ Currency = "CAD", Rate = 0.93f },
                new FxRate{ Currency = "CHF", Rate = 0.67f },
                new FxRate{ Currency = "CNY", Rate = 4.83f },
            }},
            {"CAD", new List<FxRate> {
                new FxRate{ Currency = "USD", Rate = 0.80f },
                new FxRate{ Currency = "EUR", Rate = 0.68f },
                new FxRate{ Currency = "GBP", Rate = 0.60f },
                new FxRate{ Currency = "JPY", Rate = 86.0f },
                new FxRate{ Currency = "AUD", Rate = 1.08f },
                new FxRate{ Currency = "CHF", Rate = 0.72f },
                new FxRate{ Currency = "CNY", Rate = 5.18f },
            }},
            {"CHF", new List<FxRate> {
                new FxRate{ Currency = "USD", Rate = 1.11f },
                new FxRate{ Currency = "EUR", Rate = 0.94f },
                new FxRate{ Currency = "GBP", Rate = 0.83f },
                new FxRate{ Currency = "JPY", Rate = 118.0f },
                new FxRate{ Currency = "AUD", Rate = 1.49f },
                new FxRate{ Currency = "CAD", Rate = 1.39f },
                new FxRate{ Currency = "CNY", Rate = 7.23f },
            }},
            {"CNY", new List<FxRate> {
                new FxRate{ Currency = "USD", Rate = 0.15f },
                new FxRate{ Currency = "EUR", Rate = 0.13f },
                new FxRate{ Currency = "GBP", Rate = 0.11f },
                new FxRate{ Currency = "JPY", Rate = 17.0f },
                new FxRate{ Currency = "AUD", Rate = 0.21f },
                new FxRate{ Currency = "CAD", Rate = 0.19f },
                new FxRate{ Currency = "CHF", Rate = 0.14f },
            }},

        };
        public static Dictionary<string, List<FxRate>> Rates { get; set; }

        private static Dictionary<string, List<FxRate>> HkRates { get; set; } = new Dictionary<string, List<FxRate>>(){
            {"GBP", new List<FxRate> {
                new FxRate{ Currency = "JPY", Rate = 146.0f },
                new FxRate{ Currency = "AUD", Rate = 1.81f },
                new FxRate{ Currency = "CAD", Rate = 1.67f },
                new FxRate{ Currency = "CHF", Rate = 1.21f },
                new FxRate{ Currency = "CNY", Rate = 8.71f },
            }},
            {"JPY", new List<FxRate> {
                new FxRate{ Currency = "GBP", Rate = 0.0068f },
                new FxRate{ Currency = "AUD", Rate = 0.012f },
                new FxRate{ Currency = "CAD", Rate = 0.011f },
                new FxRate{ Currency = "CHF", Rate = 0.0083f },
                new FxRate{ Currency = "CNY", Rate = 0.059f },
            }},
            {"AUD", new List<FxRate> {
                new FxRate{ Currency = "GBP", Rate = 0.55f },
                new FxRate{ Currency = "JPY", Rate = 81.0f },
                new FxRate{ Currency = "CAD", Rate = 0.93f },
                new FxRate{ Currency = "CHF", Rate = 0.67f },
                new FxRate{ Currency = "CNY", Rate = 4.83f },
            }},
            {"CAD", new List<FxRate> {
                new FxRate{ Currency = "GBP", Rate = 0.60f },
                new FxRate{ Currency = "JPY", Rate = 86.0f },
                new FxRate{ Currency = "AUD", Rate = 1.08f },
                new FxRate{ Currency = "CHF", Rate = 0.72f },
                new FxRate{ Currency = "CNY", Rate = 5.18f },
            }},
            {"CHF", new List<FxRate> {
                new FxRate{ Currency = "GBP", Rate = 0.83f },
                new FxRate{ Currency = "JPY", Rate = 118.0f },
                new FxRate{ Currency = "AUD", Rate = 1.49f },
                new FxRate{ Currency = "CAD", Rate = 1.39f },
                new FxRate{ Currency = "CNY", Rate = 7.23f },
            }},
            {"CNY", new List<FxRate> {
                new FxRate{ Currency = "GBP", Rate = 0.11f },
                new FxRate{ Currency = "JPY", Rate = 17.0f },
                new FxRate{ Currency = "AUD", Rate = 0.21f },
                new FxRate{ Currency = "CAD", Rate = 0.19f },
                new FxRate{ Currency = "CHF", Rate = 0.14f },
            }},

        };

        private static Dictionary<string, List<FxRate>> SgRates { get; set; } = new Dictionary<string, List<FxRate>>(){
            {"GBP", new List<FxRate> {
                new FxRate{ Currency = "USD", Rate = 1.33f },
                new FxRate{ Currency = "EUR", Rate = 1.14f },
                new FxRate{ Currency = "JPY", Rate = 146.0f },
                new FxRate{ Currency = "AUD", Rate = 1.81f },
            }},
            {"JPY", new List<FxRate> {
                new FxRate{ Currency = "USD", Rate = 0.0091f },
                new FxRate{ Currency = "EUR", Rate = 0.0078f },
                new FxRate{ Currency = "GBP", Rate = 0.0068f },
                new FxRate{ Currency = "AUD", Rate = 0.012f },
            }},
            {"AUD", new List<FxRate> {
                new FxRate{ Currency = "USD", Rate = 0.74f },
                new FxRate{ Currency = "EUR", Rate = 0.63f },
                new FxRate{ Currency = "GBP", Rate = 0.55f },
                new FxRate{ Currency = "JPY", Rate = 81.0f },
            }}

        };

        public static void SetRatesForEntity(string entity) {
            entity = string.IsNullOrEmpty(entity) ? "original" : entity;
            switch (entity.ToLower())
            {
                case "hk":
                    Rates = HkRates;
                    break;
                case "sg":
                    Rates = SgRates;
                    break;
                default:
                    Rates = OriginalRates; 
                    break;
            }

        }

    }
}
