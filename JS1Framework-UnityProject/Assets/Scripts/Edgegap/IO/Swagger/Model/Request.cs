using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class Request
	{
		[DataMember(Name = "request_id", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "request_id")]
		public string RequestId { get; set; }

		[DataMember(Name = "request_dns", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "request_dns")]
		public string RequestDns { get; set; }

		[DataMember(Name = "request_app", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "request_app")]
		public string RequestApp { get; set; }

		[DataMember(Name = "request_version", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "request_version")]
		public string RequestVersion { get; set; }

		[DataMember(Name = "request_user_count", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "request_user_count")]
		public int? RequestUserCount { get; set; }

		[DataMember(Name = "city", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "city")]
		public string City { get; set; }

		[DataMember(Name = "country", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "country")]
		public string Country { get; set; }

		[DataMember(Name = "continent", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "continent")]
		public string Continent { get; set; }

		[DataMember(Name = "administrative_division", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "administrative_division")]
		public string AdministrativeDivision { get; set; }

		[DataMember(Name = "tags", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "tags")]
		public List<string> Tags { get; set; }

		[DataMember(Name = "container_log_storage", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "container_log_storage")]
		public ContainerLogStorageModel ContainerLogStorage { get; set; }

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
