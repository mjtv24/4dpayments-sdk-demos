using System.Text.Json;
using System.Text.Json.Serialization;

namespace DPayments.Demos
{
  public class LocalSettings
  {
    [JsonPropertyName("DPayments")]
    public DPaymentsSettings? DPayments { get; set; }
  }

  public class DPaymentsSettings
  {
    public OfxSettings? Ofx { get; set; }
    public GatewaySettings? Gateway { get; set; }
  }

  public class OfxSettings
  {
    public string? FiUrl { get; set; }
    public string? FiOrganization { get; set; }
    public string? FiId { get; set; }
    public string? OfxUser { get; set; }
    public string? OfxPassword { get; set; }
  }

  public class GatewaySettings
  {
    public string? Url { get; set; }
    public string? MerchantId { get; set; }
    public string? ApiKey { get; set; }
  }
}
