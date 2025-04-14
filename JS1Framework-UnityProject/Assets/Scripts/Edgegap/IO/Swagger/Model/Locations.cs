using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class Locations
	{
		[DataMember(Name = "locations", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "locations")]
		public List<Location> _Locations { get; set; }

		[DataMember(Name = "messages", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "messages")]
		public List<string> Messages { get; set; }

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
