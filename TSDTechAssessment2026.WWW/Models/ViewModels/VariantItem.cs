namespace TSDTechAssessment2026.WWW.Models.ViewModels
{
	public class VariantItem
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Sku { get; set; }

		public long Stock { get; set; }

		public double Price { get; set; }

		public bool Active { get; set; }
	}
}