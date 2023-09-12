using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lojinha.NET.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    private ECommerceData eCommerceData = new();

    public List<CartItem> CartItems { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IActionResult OnGet()
    {
        CartItems = eCommerceData.GetCartItems();
        return Page();
    }

    public IActionResult OnPost()
    {
        if (Request.Form.Keys.Contains("addToCartSubmit"))
        {
            return Redirect("/addToCart");
        }

        if (Request.Form.Keys.Contains("checkoutSubmit"))
        {
            eCommerceData.CheckOut();
        }

        return OnGet();
    }
}
