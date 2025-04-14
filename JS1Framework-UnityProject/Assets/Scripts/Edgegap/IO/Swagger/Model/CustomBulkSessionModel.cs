using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class CustomBulkSessionModel
	{
		[DataMember(Name = "custom_id", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "custom_id")]
		public string CustomId { get; set; }

		[DataMember(Name = "ip_list", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "ip_list")]
		public List<string> IpList { get; set; }

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
