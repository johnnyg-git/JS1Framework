using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class Delete
	{
		[DataMember(Name = "message", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "message")]
		public string Message { get; set; }

		[DataMember(Name = "deployment_summary", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "deployment_summary")]
		public Status DeploymentSummary { get; set; }

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
