using Newtonsoft.Json;
using TSDTechAssessment2026.BusinessData.Model;

namespace TSDTechAssessment2026.API.Services
{
	public class ProductService
	{
		private readonly IWebHostEnvironment _env;
		private const string DataDirectory = "data";
		private const string ProductsFileName = "products.json";

		public ProductService(IWebHostEnvironment env)
		{
			_env = env;
		}

		public async Task<IEnumerable<Product>> GetProductsAsync()
		{
			var result = await GetProductsLibraryDataAsync();
			return result?.Products.ToList() ?? new List<Product>();
		}

		public async Task<ProductsLibrary?> GetProductsLibraryAsync()
		{
			var result = await GetProductsLibraryDataAsync();
			return result ?? new ProductsLibrary();
		}

		private async Task<ProductsLibrary?> GetProductsLibraryDataAsync()
		{
			var filePath = Path.Combine(_env.ContentRootPath, DataDirectory, ProductsFileName);
			if (!File.Exists(filePath))
			{
				return null;
			}
			var json = await File.ReadAllTextAsync(filePath);
			return JsonConvert.DeserializeObject<ProductsLibrary>(json);
		}
	}
}