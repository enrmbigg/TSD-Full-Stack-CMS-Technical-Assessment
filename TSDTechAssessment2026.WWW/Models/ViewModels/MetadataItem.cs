namespace TSDTechAssessment2026.WWW.Models.ViewModels
{
	public class MetadataItem
	{
		public long TotalProducts { get; set; }

		public DateTimeOffset Generated { get; set; }

		public string Version { get; set; }

		public string Currency { get; set; }
	}
}