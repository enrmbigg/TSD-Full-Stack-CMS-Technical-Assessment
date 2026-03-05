using Newtonsoft.Json;
using System.Text.Json;

namespace TSDTechAssessment2026.BusinessData.Model
{
	public class Variant
	{
		[JsonProperty("id")]
		public Guid Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("sku")]
		public string Sku { get; set; }

		[JsonProperty("stock")]
		public long Stock { get; set; }

		[JsonProperty("price")]
		public double Price { get; set; }

		[JsonProperty("active")]
		public bool Active { get; set; }
	}
}