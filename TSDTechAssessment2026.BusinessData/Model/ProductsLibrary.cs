using Newtonsoft.Json;
using System.Text.Json;

namespace TSDTechAssessment2026.BusinessData.Model
{
	public class ProductsLibrary
	{
		[JsonProperty("products")]
		public Product[] Products { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}
}