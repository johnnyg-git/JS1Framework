using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class MatchmakerReleaseUpdateBase
	{
		[DataMember(Name = "version", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "version")]
		public string Version { get; set; }

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
