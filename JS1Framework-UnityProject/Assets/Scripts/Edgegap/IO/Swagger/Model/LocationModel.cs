using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class LocationModel
	{
		[DataMember(Name = "latitude", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "latitude")]
		public decimal? Latitude { get; set; }

		[DataMember(Name = "longitude", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "longitude")]
		public decimal? Longitude { get; set; }

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
