using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class AppVersion
	{
		[DataMember(Name = "name", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[DataMember(Name = "is_active", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "is_active")]
		public bool? IsActive { get; set; }

		[DataMember(Name = "docker_repository", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "docker_repository")]
		public string DockerRepository { get; set; }

		[DataMember(Name = "docker_image", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "docker_image")]
		public string DockerImage { get; set; }

		[DataMember(Name = "docker_tag", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "docker_tag")]
		public string DockerTag { get; set; }

		[DataMember(Name = "private_username", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "private_username")]
		public string PrivateUsername { get; set; }

		[DataMember(Name = "private_token", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "private_token")]
		public string PrivateToken { get; set; }

		[DataMember(Name = "req_cpu", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "req_cpu")]
		public int? ReqCpu { get; set; }

		[DataMember(Name = "req_memory", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "req_memory")]
		public int? ReqMemory { get; set; }

		[DataMember(Name = "req_video", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "req_video")]
		public int? ReqVideo { get; set; }

		[DataMember(Name = "max_duration", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "max_duration")]
		public int? MaxDuration { get; set; }

		[DataMember(Name = "use_telemetry", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "use_telemetry")]
		public bool? UseTelemetry { get; set; }

		[DataMember(Name = "inject_context_env", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "inject_context_env")]
		public bool? InjectContextEnv { get; set; }

		[DataMember(Name = "whitelisting_active", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "whitelisting_active")]
		public bool? WhitelistingActive { get; set; }

		[DataMember(Name = "force_cache", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "force_cache")]
		public bool? ForceCache { get; set; }

		[DataMember(Name = "cache_min_hour", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "cache_min_hour")]
		public int? CacheMinHour { get; set; }

		[DataMember(Name = "cache_max_hour", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "cache_max_hour")]
		public int? CacheMaxHour { get; set; }

		[DataMember(Name = "time_to_deploy", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "time_to_deploy")]
		public int? TimeToDeploy { get; set; }

		[DataMember(Name = "enable_all_locations", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "enable_all_locations")]
		public bool? EnableAllLocations { get; set; }

		[DataMember(Name = "session_config", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "session_config")]
		public AppVersionCreateSessionConfig SessionConfig { get; set; }

		[DataMember(Name = "ports", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "ports")]
		public List<AppVersionPort> Ports { get; set; }

		[DataMember(Name = "probe", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "probe")]
		public AppVersionProbe Probe { get; set; }

		[DataMember(Name = "envs", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "envs")]
		public List<AppVersionEnv> Envs { get; set; }

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
