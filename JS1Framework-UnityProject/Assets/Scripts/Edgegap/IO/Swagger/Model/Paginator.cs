using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class Paginator
	{
		[DataMember(Name = "num_pages", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "num_pages")]
		public int? NumPages { get; set; }

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
