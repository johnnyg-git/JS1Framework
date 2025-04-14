using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class MatchmakerReleaseUpdate : MatchmakerReleaseUpdateBase
	{
		[DataMember(Name = "frontend_component_name", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "frontend_component_name")]
		public string FrontendComponentName { get; set; }

		[DataMember(Name = "director_component_name", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "director_component_name")]
		public string DirectorComponentName { get; set; }

		[DataMember(Name = "match_function_component_name", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "match_function_component_name")]
		public string MatchFunctionComponentName { get; set; }

		public override string ToString()
		{
			return null;
		}

		public new string ToJson()
		{
			return null;
		}
	}
}
