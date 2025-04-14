using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class ApiModelContainerlogs
	{
		[DataMember(Name = "logs", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "logs")]
		public string Logs { get; set; }

		[DataMember(Name = "encoding", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "encoding")]
		public string Encoding { get; set; }

		[DataMember(Name = "crash_logs", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "crash_logs")]
		public string CrashLogs { get; set; }

		[DataMember(Name = "crash_data", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "crash_data")]
		public ApiModelContainercrashdata CrashData { get; set; }

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
