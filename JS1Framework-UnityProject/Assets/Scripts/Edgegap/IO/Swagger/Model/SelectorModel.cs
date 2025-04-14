using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class SelectorModel
	{
		[DataMember(Name = "tag", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "tag")]
		public string Tag { get; set; }

		[DataMember(Name = "tag_only", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "tag_only")]
		public bool? TagOnly { get; set; }

		[DataMember(Name = "env", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "env")]
		public object Env { get; set; }

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
