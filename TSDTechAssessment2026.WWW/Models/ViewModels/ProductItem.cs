namespace TSDTechAssessment2026.WWW.Models.ViewModels
{
	public class ProductItem
	{
		public Guid Id { get; set; }
		
		public string Name { get; set; }

		public string Category { get; set; }

		public string Description { get; set; }

		public string Currency { get; set; }

		public bool HasImageUrl => this.Images != null && this.Images.Any() && !string.IsNullOrWhiteSpace(this.ImageUrl);
		
		public string ImageUrl => this.Images.FirstOrDefault() ?? string.Empty;

		public string[] Images { get; set; }

		public string Sku { get; set; }

		public bool HasVariants => Variants != null && Variants.Any();
		
		public IEnumerable<VariantItem> Variants { get; set; }

		public string Brand { get; set; }

		public bool HasRating => Rating > 0;

		public double Rating { get; set; }

		public long ReviewCount { get; set; }

		public bool Active { get; set; }

		public double? Price { get; set; }

		public string DisplayPrice
		{
			get
			{
				if(Price.HasValue)
					return $"{Currency} {Price.Value:F2}";
				if(Variants.Any())
					return $"From {Currency} {Variants.Min(x => x.Price):F2}";
				return "N/A";
			}
		}

		public long? Stock { get; set; }
		
		public bool InStock => Stock > 0 || Variants?.Any(x=> x.Stock > 0) == true;
	}
}