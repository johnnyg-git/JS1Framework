using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class AppCreation
	{
		[DataMember(Name = "success", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "success")]
		public bool? Success { get; set; }

		[DataMember(Name = "version", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "version")]
		public AppVersion Version { get; set; }

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
