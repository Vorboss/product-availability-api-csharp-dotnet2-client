using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Vorboss.ProductAvailability {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PostcodeAvailableProducts {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public float? Price { get; set; }

    /// <summary>
    /// Gets or Sets LeadTimeDays
    /// </summary>
    [DataMember(Name="leadTimeDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leadTimeDays")]
    public int? LeadTimeDays { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets BandwidthProvisioned
    /// </summary>
    [DataMember(Name="bandwidthProvisioned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bandwidthProvisioned")]
    public int? BandwidthProvisioned { get; set; }

    /// <summary>
    /// Gets or Sets BandwidthCapacity
    /// </summary>
    [DataMember(Name="bandwidthCapacity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bandwidthCapacity")]
    public int? BandwidthCapacity { get; set; }

    /// <summary>
    /// Gets or Sets Term
    /// </summary>
    [DataMember(Name="term", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "term")]
    public int? Term { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostcodeAvailableProducts {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  LeadTimeDays: ").Append(LeadTimeDays).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  BandwidthProvisioned: ").Append(BandwidthProvisioned).Append("\n");
      sb.Append("  BandwidthCapacity: ").Append(BandwidthCapacity).Append("\n");
      sb.Append("  Term: ").Append(Term).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
