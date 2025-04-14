using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class MetricsModel
	{
		[DataMember(Name = "labels", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "labels")]
		public List<string> Labels { get; set; }

		[DataMember(Name = "datasets", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "datasets")]
		public List<decimal?> Datasets { get; set; }

		[DataMember(Name = "timestamps", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "timestamps")]
		public List<DateTime?> Timestamps { get; set; }

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
