using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class Deployments
	{
		[DataMember(Name = "data", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "data")]
		public List<Deployment> Data { get; set; }

		[DataMember(Name = "total_count", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "total_count")]
		public int? TotalCount { get; set; }

		[DataMember(Name = "pagination", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "pagination")]
		public Pagination Pagination { get; set; }

		[DataMember(Name = "message", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "message")]
		public List<string> Message { get; set; }

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
