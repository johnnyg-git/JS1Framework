using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class AppVersionUpdateSessionConfig
	{
		[DataMember(Name = "kind", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "kind")]
		public string Kind { get; set; }

		[DataMember(Name = "sockets", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "sockets")]
		public int? Sockets { get; set; }

		[DataMember(Name = "autodeploy", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "autodeploy")]
		public bool? Autodeploy { get; set; }

		[DataMember(Name = "empty_ttl", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "empty_ttl")]
		public int? EmptyTtl { get; set; }

		[DataMember(Name = "session_max_duration", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "session_max_duration")]
		public int? SessionMaxDuration { get; set; }

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
