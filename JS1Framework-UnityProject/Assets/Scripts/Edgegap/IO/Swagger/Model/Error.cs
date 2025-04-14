using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class Error
	{
		[DataMember(Name = "message", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "message")]
		public string Message { get; set; }

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
