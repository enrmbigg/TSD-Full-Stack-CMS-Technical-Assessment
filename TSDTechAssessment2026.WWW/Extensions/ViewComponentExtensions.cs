using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;

namespace TSDTechAssessment2026.WWW.Extensions
{
	public static class ViewComponentExtensions
	{
		public static async Task<IHtmlContent> RenderProductsListing(this IViewComponentHelper vcHelper,  int pageSize = 0, string category = "",  bool showOutOfStock = false, bool showInActive = false)
		{
			return await vcHelper.InvokeAsync("ProductListing", new { pageSize, category, showOutOfStock, showInActive });
		}
	}
}
