using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class DeployEnvModel
	{
		[DataMember(Name = "key", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "key")]
		public string Key { get; set; }

		[DataMember(Name = "value", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "value")]
		public string Value { get; set; }

		[DataMember(Name = "is_hidden", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "is_hidden")]
		public bool? IsHidden { get; set; }

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
