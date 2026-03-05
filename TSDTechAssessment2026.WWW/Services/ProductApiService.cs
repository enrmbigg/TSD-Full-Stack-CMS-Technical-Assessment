using TSDTechAssessment2026.BusinessData.Model;
using TSDTechAssessment2026.WWW.Models.ViewModels;

namespace TSDTechAssessment2026.WWW.Services
{
	public class ProductApiService
	{
		private readonly HttpClient _httpClient;
		private const string API_Name = "ProductsBaseAPI";

		public ProductApiService(IHttpClientFactory factory)
		{
			_httpClient = factory.CreateClient(API_Name);
		}

		public async Task<ProductLibraryItem?> GetProductLibraryAsync()
		{
			var result = await _httpClient.GetFromJsonAsync<ProductsLibrary>("/products");

			var model = new ProductLibraryItem
			{
				Products = result?.Products?.Select(p => new ProductItem
				{
					Id = p.Id,
					Name = p.Name,
					Category = p.Category,
					Description = p.Description,
					Price = p.Price,
					Images = p.Images,
					Currency =  p.Currency,
					Sku = p.Sku,
					Brand =  p.Brand,
					Rating =  p.Rating,
					ReviewCount =  p.ReviewCount,
					Variants = p.Variants?.Select(v => new VariantItem()
					{
						Active = v.Active,
						Name = v.Name,
						Id = v.Id,
						Price = v.Price,
						Sku = v.Sku,
						Stock = v.Stock
					}),
					Active = p.Active,
					Stock = p.Stock,
				}),
				Metadata = new MetadataItem
				{
					TotalProducts = result?.Metadata.TotalProducts ?? 0,
					Generated = result?.Metadata.Generated ?? DateTimeOffset.MinValue,
					Version = result?.Metadata.Version ?? string.Empty,
					Currency = result?.Metadata.Currency ?? string.Empty
				}
			};

			return model;
		}
	}
}