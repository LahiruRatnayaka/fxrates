using FxRateApi.Data;
using FxRateApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FxRateApi.Controllers
{
    [ApiController]
    [Route("mx-fx-rates/v1/fxRates")]
    public class FxController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetFxRates([FromHeader(Name = "x-request-id")] string requestId,
                                         [FromHeader(Name = "x-requestor-id")] string requestorId,
                                         [FromHeader(Name = "x-acc-jwt")] string? accJwt,
                                         [FromQuery(Name = "fromCcy")] string? fromCcy,
                                         [FromQuery(Name = "toCcy")] string? toCcy,
                                         [FromQuery(Name = "rateType")] string rateType,
                                         [FromQuery(Name = "entityType")] string? entityType)
        {
            

            if (string.IsNullOrEmpty(rateType)) return BadRequest(new ApiError { Code = 400, Message = "rateType is required", Timestamp = DateTime.UtcNow.ToString() });

            float offerRate = 0;
            switch (rateType.ToLower())
            {
                case "b":
                    offerRate = 0.05f;
                    break;
                case "s":
                    offerRate = -0.05f;
                    break;
                case "m":
                    offerRate = 0.02f;
                    break;
                default:
                    break;
            }

            FxRateDataset.SetRatesForEntity(entityType);
            Dictionary<string, List<FxRate>> dataset = FxRateDataset.Rates;

            if (string.IsNullOrEmpty(toCcy) && string.IsNullOrEmpty(fromCcy)) return BadRequest(new ApiError { Code = 400, Message = "fromCcy or toCcy is required", Timestamp = DateTime.UtcNow.ToString() });

            if (string.IsNullOrEmpty(toCcy))
            {
                if (dataset.ContainsKey(fromCcy))
                {
                    return Ok(dataset[fromCcy].Select(rate => new FxRate { 
                        Currency = rate.Currency,
                        Rate = rate.Rate + offerRate
                    }).ToList());
                }
            }

            if (string.IsNullOrEmpty(fromCcy))
            {
                var data = dataset.Where(entry => entry.Value.Any(rate => rate.Currency == toCcy))
                    .Select(entry => new FxRate
                    {
                        Currency = entry.Key,
                        Rate = entry.Value.First(rate => rate.Currency == toCcy).Rate + offerRate
                    })
                    .ToArray();

                return Ok(data);

            }

            if (dataset.ContainsKey(fromCcy))
            {
                var rate = dataset[fromCcy].FirstOrDefault(r => r.Currency == toCcy);
                if (rate != null)
                {
                    return Ok(new FxRate
                    {
                        Currency = rate.Currency,
                        Rate = rate.Rate + offerRate
                    });
                }

                return NotFound(new ApiError { Code = 404, Message = "Rate not found", Timestamp = DateTime.UtcNow.ToString() });
            }
            else { 
                return NotFound(new ApiError { Code = 404, Message = "Rate not found", Timestamp = DateTime.UtcNow.ToString() });
            
            }
        }

        [HttpGet]
        [Route("fxRatesVersion")]
        public IActionResult GetFxRatesVersion()
        {
            string version = "2024-05-13";
            return Ok(version);
        }
    }
}
