using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class BaseModel
	{
		[DataMember(Name = "created_at", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "created_at")]
		public string CreatedAt { get; set; }

		[DataMember(Name = "updated_at", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "updated_at")]
		public string UpdatedAt { get; set; }

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
