using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class AppVersionPort
	{
		[DataMember(Name = "port", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "port")]
		public int? Port { get; set; }

		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "protocol")]
		public string Protocol { get; set; }

		[DataMember(Name = "to_check", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "to_check")]
		public bool? ToCheck { get; set; }

		[DataMember(Name = "tls_upgrade", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "tls_upgrade")]
		public bool? TlsUpgrade { get; set; }

		[DataMember(Name = "name", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

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
