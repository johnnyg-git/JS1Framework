using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class ApiModelContainercrashdata
	{
		[DataMember(Name = "exit_code", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "exit_code")]
		public int? ExitCode { get; set; }

		[DataMember(Name = "message", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "message")]
		public string Message { get; set; }

		[DataMember(Name = "restart_count", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "restart_count")]
		public int? RestartCount { get; set; }

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
