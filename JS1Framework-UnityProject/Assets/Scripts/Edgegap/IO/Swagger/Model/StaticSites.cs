using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class StaticSites
	{
		[DataMember(Name = "url", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "url")]
		public string Url { get; set; }

		[DataMember(Name = "public_ip", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "public_ip")]
		public string PublicIp { get; set; }

		[DataMember(Name = "port", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "port")]
		public decimal? Port { get; set; }

		[DataMember(Name = "latitude", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "latitude")]
		public decimal? Latitude { get; set; }

		[DataMember(Name = "longitude", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "longitude")]
		public decimal? Longitude { get; set; }

		[DataMember(Name = "city", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "city")]
		public string City { get; set; }

		public override string ToString()
		{
			return null;
		}

		public string ToJson()
		{
			return null;
		}
	}
}
