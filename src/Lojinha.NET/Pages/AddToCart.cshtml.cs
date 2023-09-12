using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lojinha.NET.Pages;

public class AddToCartModel : PageModel
{
    private readonly ILogger<AddToCartModel> _logger;
    public CartItem CartItem { get;set; }
    public List<Product> Products { get; set; }

    public AddToCartModel(ILogger<AddToCartModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        CartItem = new CartItem(0, 1, "🍇", "Grapes box", 3.50m, 1);
        Products = ECommerceData.Instance.GetProductList();
    }

    public IActionResult OnPost()
    {
        CartItem = new CartItem(0, 1, "🍇", "Grapes box", 3.50m, 1);
        ECommerceData.Instance.AddCartItem(
            new CartItem(0, 
            int.Parse(Request.Form["ProductId"].ToString()), 
            "", 
            "", 
            0, 
            int.Parse(Request.Form["Quantity"].ToString())
        ));
        return Redirect("/");
    }

    /*
    def on_post():
    ecommerce_data.add_cart_item(CartItem(0, int(request.form['ProductId']), '', '', 0, int(request.form['Quantity'])))
    return redirect('/')
    */
}
