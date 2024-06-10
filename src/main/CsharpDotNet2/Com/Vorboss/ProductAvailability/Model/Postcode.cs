using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Vorboss.ProductAvailability.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Postcode {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets _Postcode
    /// </summary>
    [DataMember(Name="postcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postcode")]
    public string _Postcode { get; set; }

    /// <summary>
    /// Gets or Sets AvailableProducts
    /// </summary>
    [DataMember(Name="availableProducts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableProducts")]
    public List<PostcodeAvailableProducts> AvailableProducts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Postcode {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  _Postcode: ").Append(_Postcode).Append("\n");
      sb.Append("  AvailableProducts: ").Append(AvailableProducts).Append("\n");
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
