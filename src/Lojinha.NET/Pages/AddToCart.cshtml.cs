using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lojinha.NET.Pages;

public class AddToCartModel : PageModel
{
    private readonly ILogger<AddToCartModel> _logger;

    private ECommerceData eCommerceData = new();

    public CartItem CartItem { get;set; }
    public List<Product> Products { get; set; }

    public AddToCartModel(ILogger<AddToCartModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
      CartItem = new CartItem(0, 1, "🍇", "Grapes box", 3.50m, 1);
      Products = eCommerceData.GetProductList();
    }
}
