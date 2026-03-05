using Microsoft.AspNetCore.Mvc;
using TSDTechAssessment2026.WWW.Models.ViewModels;
using TSDTechAssessment2026.WWW.Services;

namespace TSDTechAssessment2026.WWW.ViewComponents
{
	public class ProductListingViewComponent : ViewComponent
	{
		private readonly ProductApiService productApiService;

		public ProductListingViewComponent(ProductApiService productApiService)
		{
			this.productApiService = productApiService;
		}

		public async Task<IViewComponentResult> InvokeAsync(int pageSize, string category, bool showOutOfStock, bool showInActive)
		{
			var result = await this.productApiService.GetProductLibraryAsync();

			var products = result?.Products;

			//Rem,ove any duplicate products based on Id to ensure we only show unique products in the listing
			products = products.DistinctBy(x => x.Id);
			
			//Filter only by category if provided, otherwise show all categories
			if (!string.IsNullOrWhiteSpace(category))
			{
				products = products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
			}

			//Filter out of stock and inactive products based on the provided flags
			products = products.Where(p => showOutOfStock || p.InStock);
				
			products = products.Where(p => showInActive || p.Active);

			//Apply pagination if pageSize is greater than 0, otherwise show all products
			if (pageSize > 0)
			{
				products = products.Take(pageSize);
			}

			var model = new ProductListingModel()
			{
				Products = products
			};

			return this.View(model);
		}
	}
}