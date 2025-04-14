using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class AppVersions
	{
		[DataMember(Name = "versions", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "versions")]
		public List<AppVersion> Versions { get; set; }

		[DataMember(Name = "total_count", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "total_count")]
		public int? TotalCount { get; set; }

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
