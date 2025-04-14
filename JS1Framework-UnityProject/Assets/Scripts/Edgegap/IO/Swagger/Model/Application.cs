using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class Application
	{
		[DataMember(Name = "name", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[DataMember(Name = "is_active", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "is_active")]
		public bool? IsActive { get; set; }

		[DataMember(Name = "image", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "image")]
		public string Image { get; set; }

		[DataMember(Name = "create_time", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "create_time")]
		public string CreateTime { get; set; }

		[DataMember(Name = "last_updated", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "last_updated")]
		public string LastUpdated { get; set; }

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
