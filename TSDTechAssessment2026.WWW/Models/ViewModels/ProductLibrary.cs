using Newtonsoft.Json;

namespace TSDTechAssessment2026.WWW.Models.ViewModels
{
	public class ProductLibraryItem
	{
		[JsonProperty("products")]
		public IEnumerable<ProductItem> Products { get; set; }

		[JsonProperty("metadata")]
		public MetadataItem Metadata { get; set; }
	}
}