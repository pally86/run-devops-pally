using Microsoft.AspNetCore.Mvc.RazorPages;
using Shopping.API.Data;
using Shopping.Client.Models;

namespace run_devops_pally2.Pages
{
    public class IndexModel : PageModel
    {
        public IReadOnlyList<Product> Products { get; private set; } = Array.Empty<Product>();

        public void OnGet()
        {
            Products = ProductContext.Products;
        }
    }
}
