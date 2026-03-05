using Newtonsoft.Json;
using System.Text.Json;

namespace TSDTechAssessment2026.BusinessData.Model
{
	public class Product
	{
		[JsonProperty("id")]
		public Guid Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("category")]
		public string Category { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("images")]
		public string[] Images { get; set; }

		[JsonProperty("sku")]
		public string Sku { get; set; }

		[JsonProperty("variants", NullValueHandling = NullValueHandling.Ignore)]
		public Variant[] Variants { get; set; }

		[JsonProperty("brand")]
		public string Brand { get; set; }

		[JsonProperty("rating")]
		public double Rating { get; set; }

		[JsonProperty("reviewCount")]
		public long ReviewCount { get; set; }

		[JsonProperty("active")]
		public bool Active { get; set; }

		[JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
		public double? Price { get; set; }

		[JsonProperty("stock", NullValueHandling = NullValueHandling.Ignore)]
		public long? Stock { get; set; }
	}
}