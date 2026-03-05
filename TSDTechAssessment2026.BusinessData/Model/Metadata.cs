using Newtonsoft.Json;
using System.Text.Json;

namespace TSDTechAssessment2026.BusinessData.Model
{
	public class Metadata
	{
		[JsonProperty("totalProducts")]
		public long TotalProducts { get; set; }

		[JsonProperty("generated")]
		public DateTimeOffset Generated { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }
	}
}