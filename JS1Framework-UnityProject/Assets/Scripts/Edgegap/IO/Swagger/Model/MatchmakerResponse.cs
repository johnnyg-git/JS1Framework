using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class MatchmakerResponse : BaseModel
	{
		[DataMember(Name = "name", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

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
