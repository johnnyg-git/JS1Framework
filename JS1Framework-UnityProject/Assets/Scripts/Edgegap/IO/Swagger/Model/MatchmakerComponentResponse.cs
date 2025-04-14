using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class MatchmakerComponentResponse : BaseModel
	{
		[DataMember(Name = "name", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[DataMember(Name = "repository", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "repository")]
		public string Repository { get; set; }

		[DataMember(Name = "image", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "image")]
		public string Image { get; set; }

		[DataMember(Name = "tag", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "tag")]
		public string Tag { get; set; }

		[DataMember(Name = "credentials", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "credentials")]
		public object Credentials { get; set; }

		public override string ToString()
		{
			return null;
		}

		public new string ToJson()
		{
			return null;
		}
	}
}
