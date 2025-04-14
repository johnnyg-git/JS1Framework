using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class DeployModel
	{
		[DataMember(Name = "app_name", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "app_name")]
		public string AppName { get; set; }

		[DataMember(Name = "version_name", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "version_name")]
		public string VersionName { get; set; }

		[DataMember(Name = "is_public_app", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "is_public_app")]
		public bool? IsPublicApp { get; set; }

		[DataMember(Name = "ip_list", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "ip_list")]
		public List<string> IpList { get; set; }

		[DataMember(Name = "geo_ip_list", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "geo_ip_list")]
		public List<GeoIpListModel> GeoIpList { get; set; }

		[DataMember(Name = "env_vars", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "env_vars")]
		public List<DeployEnvModel> EnvVars { get; set; }

		[DataMember(Name = "skip_telemetry", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "skip_telemetry")]
		public bool? SkipTelemetry { get; set; }

		[DataMember(Name = "location", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "location")]
		public LocationModel Location { get; set; }

		[DataMember(Name = "city", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "city")]
		public string City { get; set; }

		[DataMember(Name = "country", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "country")]
		public string Country { get; set; }

		[DataMember(Name = "continent", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "continent")]
		public string Continent { get; set; }

		[DataMember(Name = "region", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "region")]
		public string Region { get; set; }

		[DataMember(Name = "administrative_division", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "administrative_division")]
		public string AdministrativeDivision { get; set; }

		[DataMember(Name = "webhook_url", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "webhook_url")]
		public string WebhookUrl { get; set; }

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
