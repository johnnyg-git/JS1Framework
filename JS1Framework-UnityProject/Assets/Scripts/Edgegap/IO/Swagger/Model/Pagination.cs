using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
	[DataContract]
	public class Pagination
	{
		[DataMember(Name = "number", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "number")]
		public int? Number { get; set; }

		[DataMember(Name = "next_page_number", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "next_page_number")]
		public int? NextPageNumber { get; set; }

		[DataMember(Name = "previous_page_number", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "previous_page_number")]
		public int? PreviousPageNumber { get; set; }

		[DataMember(Name = "paginator", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "paginator")]
		public Paginator Paginator { get; set; }

		[DataMember(Name = "has_next", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "has_next")]
		public bool? HasNext { get; set; }

		[DataMember(Name = "has_previous", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "has_previous")]
		public bool? HasPrevious { get; set; }

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
